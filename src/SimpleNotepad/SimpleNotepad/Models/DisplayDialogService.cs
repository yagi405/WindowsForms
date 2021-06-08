using System.Windows.Forms;
using SimpleNotepad.Presenters;
using SimpleNotepad.Util;
using SimpleNotepad.Views;

namespace SimpleNotepad.Models
{
    /// <inheritdoc cref="IDisplayDialogService"/>
    public class DisplayDialogService : IDisplayDialogService
    {
        public void ShowError(string text)
        {
            MessageBox.Show(text, AppConst.AppName,
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public DialogResult ShowYesNoCancelDialog(string text)
        {
            return MessageBox.Show(text, AppConst.AppName,
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        }

        public (DialogResult, string, string, bool) ShowReplaceDialog()
        {
            using (var replaceDialog = new Replace())
            {
                var replacePresenter = new ReplacePresenter(replaceDialog);
                replaceDialog.Tag = replacePresenter;

                // 課題に従ってモーダル表示としているが、本来はモードレスの方が望ましい
                var dr = replaceDialog.ShowDialog();

                return dr == DialogResult.Cancel
                    ? (dr, "", "", false)
                    : (dr, replaceDialog.Target, replaceDialog.Replaced, replaceDialog.CaseSensitive);
            }
        }
    }
}
