using ReactiveUI;
using Splat;
using TestNavigationProject.TestApplication;

namespace TestNavigationProject
{
    public static class AppBootstrapper
    {
        public static MauiAppBuilder UseAppBootstrapper(this MauiAppBuilder builder)
        {
            var router = new RoutingState();
            var screen = new AppBootstrapScreen(router);
            Locator.CurrentMutable.RegisterConstant(screen, typeof(IScreen)); 
            Locator.CurrentMutable.Register(() => new ChooseLanguageView(), typeof(IViewFor<ChooseLanguageViewModel>));
            Locator.CurrentMutable.Register(() => new LoginView(), typeof(IViewFor<LoginViewModel>));
            router
                .NavigateAndReset
                .Execute(new ChooseLanguageViewModel())
                .Subscribe();

            return builder;
        }

        public static Page CreateMainPage()
        {
            return new ReactiveUI.Maui.RoutedViewHost();
        }

        private class AppBootstrapScreen : ReactiveObject, IScreen
        {
            public AppBootstrapScreen(RoutingState router)
            {
                Router = router;
            }

            public RoutingState Router { get; protected set; }
        }
    }
}
