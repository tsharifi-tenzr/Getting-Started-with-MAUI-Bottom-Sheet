using Syncfusion.Maui.Toolkit.BottomSheet;
using System.Collections.ObjectModel;

namespace BottomSheet
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            bottomSheetContent.BindingContext = e.Item;
            bottomSheet.State = BottomSheetState.HalfExpanded;
            bottomSheet.Show();
        }
    }
    public class Book
    {
        public string? Title { get; set; }
        public string? Genre { get; set; }
        public string? Published { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
    }

    public class BookViewModel
    {
        public ObservableCollection<Book>? Books { get; set; }
        public BookViewModel()
        {
            Books = new ObservableCollection<Book>
            {
                new Book
                {
                    Title = "Object-Oriented Programming in C#",
                    Genre = "Programming, Software Development",
                    Published = "July 2023",
                    Description = "Object-oriented programming is a programming paradigm based on the concept of objects",
                    Price = 49.99m
                },
                new Book
                {
                    Title = "C# Code Contracts",
                    Genre = "Programming",
                    Published = "March 2019",
                    Description = "Code Contracts provide a way to convey code assumptions",
                    Price = 39.99m
                },
                new Book
                {
                    Title = "Machine Learning Using C#",
                    Genre = "Programming, Software Engineering",
                    Published = "August 2008",
                    Description = "You will learn several different approaches to applying machine learning",
                    Price = 34.99m
                },
                new Book
                {
                    Title = "Neural Networks Using C#",
                    Genre = "Programming",
                    Published = "October 1999",
                    Description = "Neural networks are an exciting field of software development",
                    Price = 49.99m
                },
                new Book
                {
                    Title = "Visual Studio Code",
                    Genre = "Software Development",
                    Published = "November 2018",
                    Description = "It is a powerful tool for editing code and serves for end-to-end programming",
                    Price = 45.99m
                },
                new Book
                {
                    Title = "Android Programming",
                    Genre = "Algorithms, Computer Science",
                    Published = "July 2009",
                    Description = "It provides a useful overview of the Android application life cycle",
                    Price = 94.99m
                },
                new Book
                {
                    Title = "iOS Succinctly",
                    Genre = "Software Design",
                    Published = "October 1994",
                    Description = "It is for developers looking to step into frightening world of iPhone",
                    Price = 54.99m
                },
                new Book
                {
                    Title = "Visual Studio 2015",
                    Genre = "Programming, Software Design",
                    Published = "October 2004",
                    Description = "The new version of the widely-used integrated development environment",
                    Price = 44.99m
                },
                new Book
                {
                    Title = "Xamarin.Forms",
                    Genre = "Software Design, Software Engineering",
                    Published = "August 2003",
                    Description = "It creates mappings from its C# classes and controls directly",
                    Price = 49.99m
                },
                new Book
                {
                    Title = "Windows Store Apps",
                    Genre = "Programming, Web Development",
                    Published = "March 2023",
                    Description = "Windows Store apps present a radical shift in Windows development",
                    Price = 59.99m
                }
            };
        }
    }
}
