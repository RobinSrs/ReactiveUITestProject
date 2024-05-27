namespace TestNavigationProject
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = AppBootstrapper.CreateMainPage();
        }
    }
}
