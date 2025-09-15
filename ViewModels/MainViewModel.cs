using System.Collections.ObjectModel;
using System.ComponentModel;
using MovieLibrary.Models;
using MovieLibrary.Data;
using System;

namespace MovieLibrary.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Movie> Movies { get; set; }

        private Movie selectedMovie;
        public Movie SelectedMovie
        {
            get => selectedMovie;
            set { selectedMovie = value; OnPropertyChanged(nameof(SelectedMovie)); }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string name) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        public MainViewModel()
        {
            var list = MockData.GetMockMovies();
            Movies = new ObservableCollection<Movie>(list);
        }

        public void AddMovie(Movie movie)
        {
            if (movie == null) return;
            movie.Id = Guid.NewGuid();
            Movies.Add(movie);
        }

        public void RemoveSelected()
        {
            if (SelectedMovie != null)
            {
                Movies.Remove(SelectedMovie);
                SelectedMovie = null;
            }
        }
    }
}
