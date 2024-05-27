using System.Reactive.Disposables;
using ReactiveUI;

namespace TestNavigationProject.TestApplication
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChooseLanguageView : BasePage<ChooseLanguageViewModel>
    {
        public ChooseLanguageView()
        {
            InitializeComponent();

            this.WhenActivated(
                disposables =>
                {
                    this.OneWayBind(ViewModel, vm => vm.LoggingIn, v => v.Spinner.IsRunning, x => x)
                        .DisposeWith(disposables);
                    this.OneWayBind(ViewModel, vm => vm.LoggingIn, v => v.Flags.IsVisible, x => !x)
                        .DisposeWith(disposables);

                    this.BindCommand(ViewModel, vm => vm.SetLanguageCommand, v => v.SwitchLanguageNL).DisposeWith(disposables);
                    this.BindCommand(ViewModel, vm => vm.SetLanguageCommand, v => v.SwitchLanguageUK).DisposeWith(disposables);
                });
        }
    }
}
