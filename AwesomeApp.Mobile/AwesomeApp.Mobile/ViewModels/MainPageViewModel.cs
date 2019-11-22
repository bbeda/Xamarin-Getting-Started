using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;

namespace AwesomeApp.Mobile.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {

        public MainPageViewModel()
        {
            EraseCommand = new Command(() => TheNote = string.Empty);
            SaveCommand = new Command(() => { AllNotes.Add(TheNote); TheNote = string.Empty; });
            SelectedNoteChangedCommand = new Command(async () =>
            {
                var detailVM = new DetailPageViewModel(SelectedNote);
                var detailPage = new DetailPage();
                detailPage.BindingContext = detailVM;
                await Application.Current.MainPage.Navigation.PushModalAsync(detailPage);
            });
        }

        public ObservableCollection<string> AllNotes { get; } = new ObservableCollection<string>();

        private string theNote;
        public string TheNote
        {
            get => theNote;
            set
            {
                theNote = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(TheNote)));
            }
        }

        private string selectedNote;
        public string SelectedNote
        {
            get => selectedNote;
            set
            {
                selectedNote = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SelectedNote)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public Command SaveCommand { get; }
        public Command EraseCommand { get; }
        public Command SelectedNoteChangedCommand { get; }



    }
}
