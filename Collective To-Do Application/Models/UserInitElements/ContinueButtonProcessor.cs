using Collective_To_Do_Application.ViewModels.Elements;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace Collective_To_Do_Application.Models.UserInitElements
{
    public partial class ContinueButtonProcessor : ObservableObject
    {
        #region properties
        [ObservableProperty]
        private bool _isContinueButEnable = false;
        #endregion

        public void SetButtonStatus(ObservableCollection<TextBoxViewModel> textBoxes, string firstName, string lastName)
        {
            // IsContinueButEnable is true by default, if one field empty - change it to false
            IsContinueButEnable = true;
            if ((firstName == null || firstName == "") || (lastName == null || lastName == ""))
                IsContinueButEnable = false;
            else
                foreach (TextBoxViewModel textBox in textBoxes)
                    if (textBox.Text == null || textBox.Text == "")
                        IsContinueButEnable = false;
        }
    }
}
