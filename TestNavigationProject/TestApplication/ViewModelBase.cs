using ReactiveUI;
using Splat;

namespace TestNavigationProject.TestApplication
{
    public class ViewModelBase : ReactiveObject, IRoutableViewModel, IActivatableViewModel
    {
        public string UrlPathSegment
        {
            get;
            protected set;
        }

        public IScreen HostScreen
        {
            get;
            protected set;
        }

        public ViewModelActivator Activator { get; set; }

        public ViewModelBase()
        {
            Activator = new ViewModelActivator();
            HostScreen = Locator.Current.GetService<IScreen>();
        }
    }
}
