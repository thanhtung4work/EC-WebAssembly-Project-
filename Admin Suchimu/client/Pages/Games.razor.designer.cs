using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using Radzen.Blazor;
using Admin.Models.Suchimnu;
using Admin.Client.Pages;

namespace Admin.Pages
{
    public partial class GamesComponent : ComponentBase
    {
        [Parameter(CaptureUnmatchedValues = true)]
        public IReadOnlyDictionary<string, dynamic> Attributes { get; set; }

        public void Reload()
        {
            InvokeAsync(StateHasChanged);
        }

        public void OnPropertyChanged(PropertyChangedEventArgs args)
        {
        }

        [Inject]
        protected IJSRuntime JSRuntime { get; set; }

        [Inject]
        protected NavigationManager UriHelper { get; set; }

        [Inject]
        protected DialogService DialogService { get; set; }

        [Inject]
        protected TooltipService TooltipService { get; set; }

        [Inject]
        protected ContextMenuService ContextMenuService { get; set; }

        [Inject]
        protected NotificationService NotificationService { get; set; }

        [Inject]
        protected SuchimnuService Suchimnu { get; set; }
        protected RadzenDataGrid<Admin.Models.Suchimnu.Game> grid0;

        string _search;
        protected string search
        {
            get
            {
                return _search;
            }
            set
            {
                if (!object.Equals(_search, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "search", NewValue = value, OldValue = _search };
                    _search = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        IEnumerable<Admin.Models.Suchimnu.Game> _getGamesResult;
        protected IEnumerable<Admin.Models.Suchimnu.Game> getGamesResult
        {
            get
            {
                return _getGamesResult;
            }
            set
            {
                if (!object.Equals(_getGamesResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getGamesResult", NewValue = value, OldValue = _getGamesResult };
                    _getGamesResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        int _getGamesCount;
        protected int getGamesCount
        {
            get
            {
                return _getGamesCount;
            }
            set
            {
                if (!object.Equals(_getGamesCount, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getGamesCount", NewValue = value, OldValue = _getGamesCount };
                    _getGamesCount = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        protected override async System.Threading.Tasks.Task OnInitializedAsync()
        {
            await Load();
        }
        protected async System.Threading.Tasks.Task Load()
        {
            if (string.IsNullOrEmpty(search)) {
                search = "";
            }
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            var dialogResult = await DialogService.OpenAsync<AddGame>("Add Game", null);
            await grid0.Reload();

            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Splitbutton0Click(RadzenSplitButtonItem args)
        {
            if (args?.Value == "csv")
            {
                await Suchimnu.ExportGamesToCSV(new Query() { Filter = $@"{(string.IsNullOrEmpty(grid0.Query.Filter)? "true" : grid0.Query.Filter)}", OrderBy = $"{grid0.Query.OrderBy}", Expand = "Category,Studio", Select = "Id,Title,Description,ShortDescription,ImageUrl,Price,OriginalPrice,IsActive,Category.Name as CategoryName,Studio.Name as StudioName,CreateDate,LatestUpdate" }, $"Games");

            }

            if (args == null || args.Value == "xlsx")
            {
                await Suchimnu.ExportGamesToExcel(new Query() { Filter = $@"{(string.IsNullOrEmpty(grid0.Query.Filter)? "true" : grid0.Query.Filter)}", OrderBy = $"{grid0.Query.OrderBy}", Expand = "Category,Studio", Select = "Id,Title,Description,ShortDescription,ImageUrl,Price,OriginalPrice,IsActive,Category.Name as CategoryName,Studio.Name as StudioName,CreateDate,LatestUpdate" }, $"Games");

            }
        }

        protected async System.Threading.Tasks.Task Grid0LoadData(LoadDataArgs args)
        {
            try
            {
                var suchimnuGetGamesResult = await Suchimnu.GetGames(filter:$@"(contains(Title,""{search}"") or contains(Description,""{search}"") or contains(ShortDescription,""{search}"") or contains(ImageUrl,""{search}"")) and {(string.IsNullOrEmpty(args.Filter)? "true" : args.Filter)}", orderby:$"{args.OrderBy}", expand:$"Category,Studio", top:args.Top, skip:args.Skip, count:args.Top != null && args.Skip != null);
                getGamesResult = suchimnuGetGamesResult.Value.AsODataEnumerable();

                getGamesCount = suchimnuGetGamesResult.Count;
            }
            catch (System.Exception suchimnuGetGamesException)
            {
                NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Error,Summary = $"Error",Detail = $"Unable to load Games" });
            }
        }

        protected async System.Threading.Tasks.Task Grid0RowDoubleClick(DataGridRowMouseEventArgs<Admin.Models.Suchimnu.Game> args)
        {
            var dialogResult = await DialogService.OpenAsync<EditGame>("Edit Game", new Dictionary<string, object>() { {"Id", args.Data.Id} });
            await grid0.Reload();

            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                if (await DialogService.Confirm("Are you sure you want to delete this record?") == true)
                {
                    var suchimnuDeleteGameResult = await Suchimnu.DeleteGame(id:data.Id);
                    if (suchimnuDeleteGameResult != null && suchimnuDeleteGameResult.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        await grid0.Reload();
                    }

                    if (suchimnuDeleteGameResult != null && suchimnuDeleteGameResult.StatusCode != System.Net.HttpStatusCode.NoContent)
                    {
                        NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Error,Summary = $"Error",Detail = $"Unable to delete Game" });
                    }
                }
            }
            catch (System.Exception suchimnuDeleteGameException)
            {
                NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Error,Summary = $"Error",Detail = $"Unable to delete Game" });
            }
        }
    }
}
