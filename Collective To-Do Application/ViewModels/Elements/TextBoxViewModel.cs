using CommunityToolkit.Mvvm.ComponentModel;
using System.Text.RegularExpressions;

namespace Collective_To_Do_Application.ViewModels.Elements
{
    /// <summary>
    /// ViewModel for TextBoxes from RegistrationView.xaml
    /// </summary>
    public class TextBoxViewModel : ObservableObject
    {
        private UserInitElementsViewModel ParentVM { get; set; }
        public TextBoxViewModel(UserInitElementsViewModel parentVM) => ParentVM = parentVM;

        public int Id { get; set; }

        private string _text;
        public string Text
        {
            get => _text;
            set
            {
                // only numbers from 0 to 9 and an empty value are allowed
                if (Regex.IsMatch(value, @"^[0-9]*$") || value == "")
                {
                    _text = value;
                    OnPropertyChanged("Text");

                    // check Continue Button status with new params
                    ParentVM.ContinueButtonProcessor.SetButtonStatus
                            (ParentVM.TextBoxes, ParentVM.PersonDataProcessor.FirstName, ParentVM.PersonDataProcessor.LastName);
                }
            }
        }
    }
}
