using System.Windows;
using System.Windows.Controls;
using MovieLibrary.ViewModels;

namespace MovieLibrary.Views
{
    public partial class MoviesPage : Page
    {
        private readonly MainViewModel vm;
        public MoviesPage(MainViewModel vm)
        {
            InitializeComponent();
            this.vm = vm;
            this.DataContext = vm;
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (vm.SelectedMovie == null)
            {
                MessageBox.Show("Choose a movie first.");
                return;
            }
            if (MessageBox.Show($"Do you want to delete? '{vm.SelectedMovie.Title}'?", "Confirm", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                vm.RemoveSelected();
            }
        }
    }
}
