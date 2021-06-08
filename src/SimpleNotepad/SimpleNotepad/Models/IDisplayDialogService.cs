using System.Windows.Forms;

namespace SimpleNotepad.Models
{
    public interface IDisplayDialogService
    {
        void ShowError(string text);

        DialogResult ShowYesNoCancelDialog(string text);

        (DialogResult, string, string, bool) ShowReplaceDialog();
    }
    
}
