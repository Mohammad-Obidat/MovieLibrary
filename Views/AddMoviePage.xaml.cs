using System;
using System.Windows;
using System.Windows.Controls;
using MovieLibrary.ViewModels;
using MovieLibrary.Models;

namespace MovieLibrary.Views
{
    public partial class AddMoviePage : Page
    {
        private readonly MainViewModel vm;
        public AddMoviePage(MainViewModel vm)
        {
            InitializeComponent();
            this.vm = vm;
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtTitle.Text))
            {
                MessageBox.Show("Title Required.");
                return;
            }

            int.TryParse(TxtYear.Text, out int year);
            int.TryParse(TxtDuration.Text, out int duration);
            double.TryParse(TxtRating.Text, out double rating);

            string coverFile = TxtCoverUrl.Text.Trim();

            if (string.IsNullOrEmpty(coverFile))
            {
                coverFile = "pack://application:,,,/Assets/default.jpg";
            }
            else
            {
                if (!coverFile.StartsWith("Assets/"))
                    coverFile = System.IO.Path.Combine("Assets", coverFile);

                coverFile = $"pack://application:,,,/{coverFile}";
            }

            var m = new Movie
            {
                Title = TxtTitle.Text.Trim(),
                Director = TxtDirector.Text.Trim(),
                Year = year,
                Genre = TxtGenre.Text.Trim(),
                Duration = duration,
                Rating = rating,
                CoverImageUrl = coverFile,
                Description = ""
            };

            vm.AddMovie(m);
            MessageBox.Show("Added.");

            TxtTitle.Text = TxtDirector.Text = TxtYear.Text = TxtGenre.Text =
                TxtDuration.Text = TxtRating.Text = TxtCoverUrl.Text = "";
        }
    }
}
