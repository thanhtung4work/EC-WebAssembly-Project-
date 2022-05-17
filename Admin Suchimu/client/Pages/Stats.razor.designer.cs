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
    public partial class StatsComponent : ComponentBase
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
        protected RadzenDataGrid<Admin.Models.Suchimnu.Stat> grid0;

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

        IEnumerable<Admin.Models.Suchimnu.Stat> _getStatsResult;
        protected IEnumerable<Admin.Models.Suchimnu.Stat> getStatsResult
        {
            get
            {
                return _getStatsResult;
            }
            set
            {
                if (!object.Equals(_getStatsResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getStatsResult", NewValue = value, OldValue = _getStatsResult };
                    _getStatsResult = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        int _getStatsCount;
        protected int getStatsCount
        {
            get
            {
                return _getStatsCount;
            }
            set
            {
                if (!object.Equals(_getStatsCount, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getStatsCount", NewValue = value, OldValue = _getStatsCount };
                    _getStatsCount = value;
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
            var dialogResult = await DialogService.OpenAsync<AddStat>("Add Stat", null);
            await grid0.Reload();

            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task Splitbutton0Click(RadzenSplitButtonItem args)
        {
            if (args?.Value == "csv")
            {
                await Suchimnu.ExportStatsToCSV(new Query() { Filter = $@"{(string.IsNullOrEmpty(grid0.Query.Filter)? "true" : grid0.Query.Filter)}", OrderBy = $"{grid0.Query.OrderBy}", Expand = "", Select = "Id,Visits,LastVisit" }, $"Stats");

            }

            if (args == null || args.Value == "xlsx")
            {
                await Suchimnu.ExportStatsToExcel(new Query() { Filter = $@"{(string.IsNullOrEmpty(grid0.Query.Filter)? "true" : grid0.Query.Filter)}", OrderBy = $"{grid0.Query.OrderBy}", Expand = "", Select = "Id,Visits,LastVisit" }, $"Stats");

            }
        }

        protected async System.Threading.Tasks.Task Grid0LoadData(LoadDataArgs args)
        {
            try
            {
                var suchimnuGetStatsResult = await Suchimnu.GetStats(filter:$@"{(string.IsNullOrEmpty(args.Filter)? "true" : args.Filter)}", orderby:$"{args.OrderBy}", top:args.Top, skip:args.Skip, count:args.Top != null && args.Skip != null);
                getStatsResult = suchimnuGetStatsResult.Value.AsODataEnumerable();

                getStatsCount = suchimnuGetStatsResult.Count;
            }
            catch (System.Exception suchimnuGetStatsException)
            {
                NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Error,Summary = $"Error",Detail = $"Unable to load Stats" });
            }
        }

        protected async System.Threading.Tasks.Task Grid0RowDoubleClick(DataGridRowMouseEventArgs<Admin.Models.Suchimnu.Stat> args)
        {
            var dialogResult = await DialogService.OpenAsync<EditStat>("Edit Stat", new Dictionary<string, object>() { {"Id", args.Data.Id} });
            await grid0.Reload();

            await InvokeAsync(() => { StateHasChanged(); });
        }

        protected async System.Threading.Tasks.Task GridDeleteButtonClick(MouseEventArgs args, dynamic data)
        {
            try
            {
                if (await DialogService.Confirm("Are you sure you want to delete this record?") == true)
                {
                    var suchimnuDeleteStatResult = await Suchimnu.DeleteStat(id:data.Id);
                    if (suchimnuDeleteStatResult != null && suchimnuDeleteStatResult.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        await grid0.Reload();
                    }

                    if (suchimnuDeleteStatResult != null && suchimnuDeleteStatResult.StatusCode != System.Net.HttpStatusCode.NoContent)
                    {
                        NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Error,Summary = $"Error",Detail = $"Unable to delete Stat" });
                    }
                }
            }
            catch (System.Exception suchimnuDeleteStatException)
            {
                NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Error,Summary = $"Error",Detail = $"Unable to delete Stat" });
            }
        }
    }
}
