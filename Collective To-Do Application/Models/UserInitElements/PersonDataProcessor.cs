using Collective_To_Do_Application.ViewModels;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Collective_To_Do_Application.Models.UserInitElements
{
    public partial class PersonDataProcessor : ObservableObject
    {
        public UserInitElementsViewModel ParentVM { get; set; }
        public PersonDataProcessor(UserInitElementsViewModel parentVM) { ParentVM = parentVM; }

        private string _firstName;
        public string FirstName
        {
            get => _firstName;
            set
            {
                _firstName = value;
                ParentVM.ContinueButtonProcessor.SetButtonStatus(ParentVM.TextBoxes, FirstName, LastName);
            }
        }

        private string _lastName;
        public string LastName
        {
            get => _lastName;
            set
            {
                _lastName = value;
                ParentVM.ContinueButtonProcessor.SetButtonStatus(ParentVM.TextBoxes, FirstName, LastName);
            }
        }
    }
}
