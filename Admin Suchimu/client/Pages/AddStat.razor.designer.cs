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
    public partial class AddStatComponent : ComponentBase
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

        Admin.Models.Suchimnu.Stat _stat;
        protected Admin.Models.Suchimnu.Stat stat
        {
            get
            {
                return _stat;
            }
            set
            {
                if (!object.Equals(_stat, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "stat", NewValue = value, OldValue = _stat };
                    _stat = value;
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
            stat = new Admin.Models.Suchimnu.Stat(){};
        }

        protected async System.Threading.Tasks.Task Form0Submit(Admin.Models.Suchimnu.Stat args)
        {
            try
            {
                var suchimnuCreateStatResult = await Suchimnu.CreateStat(stat:stat);
                DialogService.Close(stat);
            }
            catch (System.Exception suchimnuCreateStatException)
            {
                NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Error,Summary = $"Error",Detail = $"Unable to create new Stat!" });
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
