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
    public partial class StudiosComponent : ComponentBase
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
        protected RadzenDataGrid<Admin.Models.Suchimnu.Studio> grid0;

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

        IEnumerable<Admin.Models.Suchimnu.Studio> _getStudiosResult;
        protected IEnumerable<Admin.Models.Suchimnu.Studio> getStudiosResult
        {
            get
            {
                return _getStudiosResult;
            }
            set
            {
                if (!object.Equals(_getStudiosResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getStudiosResult", NewValue = value, OldValue = _getStudiosResult };
                    _getStudiosResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        int _getStudiosCount;
        protected int getStudiosCount
        {
            get
            {
                return _getStudiosCount;
            }
            set
            {
                if (!object.Equals(_getStudiosCount, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getStudiosCount", NewValue = value, OldValue = _getStudiosCount };
                    _getStudiosCount = value;
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
            var dialogResult = await DialogService.OpenAsync<AddStudio>("Add Studio", null);
            await grid0.Reload();

            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Splitbutton0Click(RadzenSplitButtonItem args)
        {
            if (args?.Value == "csv")
            {
                await Suchimnu.ExportStudiosToCSV(new Query() { Filter = $@"{(string.IsNullOrEmpty(grid0.Query.Filter)? "true" : grid0.Query.Filter)}", OrderBy = $"{grid0.Query.OrderBy}", Expand = "", Select = "Id,Name,Location,Email,ImageUrl,Url" }, $"Studios");

            }

            if (args == null || args.Value == "xlsx")
            {
                await Suchimnu.ExportStudiosToExcel(new Query() { Filter = $@"{(string.IsNullOrEmpty(grid0.Query.Filter)? "true" : grid0.Query.Filter)}", OrderBy = $"{grid0.Query.OrderBy}", Expand = "", Select = "Id,Name,Location,Email,ImageUrl,Url" }, $"Studios");

            }
        }

        protected async System.Threading.Tasks.Task Grid0LoadData(LoadDataArgs args)
        {
            try
            {
                var suchimnuGetStudiosResult = await Suchimnu.GetStudios(filter:$@"(contains(Name,""{search}"") or contains(Location,""{search}"") or contains(Email,""{search}"") or contains(ImageUrl,""{search}"") or contains(Url,""{search}"")) and {(string.IsNullOrEmpty(args.Filter)? "true" : args.Filter)}", orderby:$"{args.OrderBy}", top:args.Top, skip:args.Skip, count:args.Top != null && args.Skip != null);
                getStudiosResult = suchimnuGetStudiosResult.Value.AsODataEnumerable();

                getStudiosCount = suchimnuGetStudiosResult.Count;
            }
            catch (System.Exception suchimnuGetStudiosException)
            {
                NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Error,Summary = $"Error",Detail = $"Unable to load Studios" });
            }
        }

        protected async System.Threading.Tasks.Task Grid0RowDoubleClick(DataGridRowMouseEventArgs<Admin.Models.Suchimnu.Studio> args)
        {
            var dialogResult = await DialogService.OpenAsync<EditStudio>("Edit Studio", new Dictionary<string, object>() { {"Id", args.Data.Id} });
            await grid0.Reload();

            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                if (await DialogService.Confirm("Are you sure you want to delete this record?") == true)
                {
                    var suchimnuDeleteStudioResult = await Suchimnu.DeleteStudio(id:data.Id);
                    if (suchimnuDeleteStudioResult != null && suchimnuDeleteStudioResult.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        await grid0.Reload();
                    }

                    if (suchimnuDeleteStudioResult != null && suchimnuDeleteStudioResult.StatusCode != System.Net.HttpStatusCode.NoContent)
                    {
                        NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Error,Summary = $"Error",Detail = $"Unable to delete Studio" });
                    }
                }
            }
            catch (System.Exception suchimnuDeleteStudioException)
            {
                NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Error,Summary = $"Error",Detail = $"Unable to delete Studio" });
            }
        }
    }
}
