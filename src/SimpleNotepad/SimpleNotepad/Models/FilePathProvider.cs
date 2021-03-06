using System.Windows.Forms;

namespace SimpleNotepad.Models
{
    public class FilePathProvider : IFilePathProvider
    {
        private const string Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

        public string GetOpenFilePath()
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = Filter;
                openFileDialog.FilterIndex = 1;
                openFileDialog.CheckFileExists = true;
                openFileDialog.Multiselect = false;
                var dr = openFileDialog.ShowDialog();
                return dr == DialogResult.OK ? openFileDialog.FileName : null;
            }
        }

        public string GetSaveFilePath()
        {
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = Filter;
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.DefaultExt = "txt";
                var dr = saveFileDialog.ShowDialog();
                return dr == DialogResult.OK ? saveFileDialog.FileName : null;
            }
        }
    }
}
