using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;

namespace XAMLUI.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public MainPageViewModel()
        {
            EraseCommand = new Command(() =>
           {
               theNote = String.Empty;
           });

            SaveCommand = new Command(() =>
            {
                AllNotes.Add(TheNote);

                theNote = string.Empty;
            }
        }

        public ObservableCollection<string> AllNotes { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        string theNote;
        public string Note
        {
            get => theNote;
            set
            {
                theNote = value;

                var args = new PropertyChangedEventArgs(nameof(theNote));

                PropertyChanged?.Invoke(this, args);
            }
        }

        Command SaveCommand { get;  }
        Command EraseCommand { get; }
        
    }
}