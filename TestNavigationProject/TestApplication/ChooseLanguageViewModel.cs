using System.Globalization;
using System.Reactive;
using System.Reactive.Linq;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace TestNavigationProject.TestApplication
{
    public class ChooseLanguageViewModel : ViewModelBase
    {
        [Reactive] public bool LoggingIn { get; set; }
        public ReactiveCommand<string, Unit> SetLanguageCommand { get; }

        public ChooseLanguageViewModel() : base()
        {
            SetLanguageCommand = ReactiveCommand.CreateFromTask<string>(SetLanguage);
        }

        private async Task SetLanguage(string newLanguage)
        {
            LoggingIn = true;
            CultureInfo.CurrentCulture = new CultureInfo(newLanguage);
            await HostScreen.Router.NavigateAndReset.Execute(new LoginViewModel());
            LoggingIn = false;
        }
    }
}
