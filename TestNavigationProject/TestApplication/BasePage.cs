using ReactiveUI.Maui;

namespace TestNavigationProject.TestApplication
{
    public abstract class BasePage<T> : ReactiveContentPage<T> where T : ViewModelBase
    {
    }
}
