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
    public partial class EditGameComponent : ComponentBase
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

        [Parameter]
        public dynamic Id { get; set; }

        bool _hasChanges;
        protected bool hasChanges
        {
            get
            {
                return _hasChanges;
            }
            set
            {
                if (!object.Equals(_hasChanges, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "hasChanges", NewValue = value, OldValue = _hasChanges };
                    _hasChanges = value;
                    OnPropertyChanged(args);
                    Reload();
                }
            }
        }

        bool _canEdit;
        protected bool canEdit
        {
            get
            {
                return _canEdit;
            }
            set
            {
                if (!object.Equals(_canEdit, value))
                {
                    var args = new PropertyChangedEventArgs(){ Name = "canEdit", NewValue = value, OldValue = _canEdit };
                    _canEdit = value;
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

        protected override async System.Threading.Tasks.Task OnInitializedAsync()
        {
            await Load();
        }
        protected async System.Threading.Tasks.Task Load()
        {
            hasChanges = false;

            canEdit = true;

            var suchimnuGetGameByIdResult = await Suchimnu.GetGameById(id:Id);
            game = suchimnuGetGameByIdResult;

            canEdit = suchimnuGetGameByIdResult != null;

            var suchimnuGetCategoriesResult = await Suchimnu.GetCategories();
            getCategoriesResult = suchimnuGetCategoriesResult.Value.AsODataEnumerable();

            var suchimnuGetStudiosResult = await Suchimnu.GetStudios();
            getStudiosResult = suchimnuGetStudiosResult.Value.AsODataEnumerable();
        }

        protected async System.Threading.Tasks.Task CloseButtonClick(MouseEventArgs args)
        {
            DialogService.Close(null);
        }

        protected async System.Threading.Tasks.Task Button0Click(MouseEventArgs args)
        {
            await this.Load();
        }

        protected async System.Threading.Tasks.Task Form0Submit(Admin.Models.Suchimnu.Game args)
        {
            try
            {
                var suchimnuUpdateGameResult = await Suchimnu.UpdateGame(id:Id, game:game);
                if (suchimnuUpdateGameResult.StatusCode != System.Net.HttpStatusCode.PreconditionFailed) {
                  DialogService.Close(game);
                }

                hasChanges = suchimnuUpdateGameResult.StatusCode == System.Net.HttpStatusCode.PreconditionFailed;
            }
            catch (System.Exception suchimnuUpdateGameException)
            {
                NotificationService.Notify(new NotificationMessage(){ Severity = NotificationSeverity.Error,Summary = $"Error",Detail = $"Unable to update Game" });

            hasChanges = suchimnuUpdateGameException.Message.Contains("412");

            if (!suchimnuUpdateGameException.Message.Contains("412")) {
                canEdit = false;
            }
            }
        }

        protected async System.Threading.Tasks.Task Button4Click(MouseEventArgs args)
        {
            DialogService.Close(null);
        }
    }
}
