using System.Windows;
using MovieLibrary.ViewModels;
using MovieLibrary.Views;

namespace MovieLibrary
{
    public partial class MainWindow : Window
    {
        private readonly MainViewModel vm;
        public MainWindow()
        {
            InitializeComponent();
            vm = new MainViewModel();
            // Start page
            MainFrame.Navigate(new MoviesPage(vm));
        }

        private void BtnHome_Click(object sender, RoutedEventArgs e)
            => MainFrame.Navigate(new MoviesPage(vm));

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
            => MainFrame.Navigate(new AddMoviePage(vm));

        private void BtnAbout_Click(object sender, RoutedEventArgs e)
            => MainFrame.Navigate(new AboutPage());
    }
}
