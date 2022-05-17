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
    public partial class AddGameComponent : ComponentBase
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

        IEnumerable<Admin.Models.Suchimnu.Category> _getCategoriesResult;
        protected IEnumerable<Admin.Models.Suchimnu.Category> getCategoriesResult
        {
            get
            {
                return _getCategoriesResult;
            }
            set
            {
                if (!object.Equals(_getCategoriesResult, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "getCategoriesResult", NewValue = value, OldValue = _getCategoriesResult };
                    _getCategoriesResult = value;
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

        Admin.Models.Suchimnu.Game _game;
        protected Admin.Models.Suchimnu.Game game
        {
            get
            {
                return _game;
            }
            set
            {
                if (!object.Equals(_game, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "game", NewValue = value, OldValue = _game };
                    _game = value;
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
            var suchimnuGetCategoriesResult = await Suchimnu.GetCategories();
            getCategoriesResult = suchimnuGetCategoriesResult.Value.AsODataEnumerable();

            var suchimnuGetStudiosResult = await Suchimnu.GetStudios();
            getStudiosResult = suchimnuGetStudiosResult.Value.AsODataEnumerable();

            game = new Admin.Models.Suchimnu.Game(){};
        }

        protected async System.Threading.Tasks.Task Form0Submit(Admin.Models.Suchimnu.Game args)
        {
            try
            {
                var suchimnuCreateGameResult = await Suchimnu.CreateGame(game:game);
                DialogService.Close(game);
            }
            catch (System.Exception suchimnuCreateGameException)
            {
                NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Error,Summary = $"Error",Detail = $"Unable to create new Game!" });
            }
        }

        protected async System.Threading.Tasks.Task Button2Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
