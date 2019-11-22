using System.ComponentModel;
using Xamarin.Forms;

namespace AwesomeApp.Mobile.ViewModels
{
    public class DetailPageViewModel : INotifyPropertyChanged
    {
        private string noteText;

        public DetailPageViewModel(string note)
        {
            NoteText = note;
            DismissPageCommand = new Command(async () => await Application.Current.MainPage.Navigation.PopModalAsync());

        }

        public string NoteText
        {
            get
            {
                return noteText;
            }
            set
            {
                noteText = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(NoteText)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public Command DismissPageCommand { get; }
    }
}
