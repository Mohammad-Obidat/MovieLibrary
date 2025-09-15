using System;
using System.ComponentModel;

namespace MovieLibrary.Models
{
    public class Movie : INotifyPropertyChanged
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        private string title;
        public string Title { get => title; set { title = value; OnPropertyChanged(nameof(Title)); } }

        private string director;
        public string Director { get => director; set { director = value; OnPropertyChanged(nameof(Director)); } }

        private int year;
        public int Year { get => year; set { year = value; OnPropertyChanged(nameof(Year)); } }

        private string genre;
        public string Genre { get => genre; set { genre = value; OnPropertyChanged(nameof(Genre)); } }

        private string description;
        public string Description { get => description; set { description = value; OnPropertyChanged(nameof(Description)); } }

        private int duration;
        public int Duration { get => duration; set { duration = value; OnPropertyChanged(nameof(Duration)); } }

        private double rating;
        public double Rating { get => rating; set { rating = value; OnPropertyChanged(nameof(Rating)); } }

        private string coverImageUrl;
        public string CoverImageUrl { get => coverImageUrl; set { coverImageUrl = value; OnPropertyChanged(nameof(CoverImageUrl)); } }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string name) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
