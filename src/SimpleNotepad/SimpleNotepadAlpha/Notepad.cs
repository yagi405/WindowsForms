using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace SimpleNotepadAlpha
{
    public partial class Notepad : Form
    {
        private const string DefaultFileName = "(無題)";
        private const string Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

        public string OpenFilePath { get; private set; }

        public bool HasOpenFile => !string.IsNullOrEmpty(OpenFilePath);

        public string OpenFileName => HasOpenFile
            ? Path.GetFileName(OpenFilePath)
            : DefaultFileName;

        public Notepad()
        {
            InitializeComponent();
        }

        private void Notepad_Load(object sender, EventArgs e)
        {
            Initialize();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Initialize();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Filter = Filter;
                dialog.FilterIndex = 1;
                dialog.CheckFileExists = true;
                dialog.Multiselect = false;

                var dialogResult = dialog.ShowDialog();
                if (dialogResult != DialogResult.OK)
                {
                    return;
                }

                OpenFilePath = dialog.FileName;

                try
                {
                    var text = File.ReadAllText(OpenFilePath);
                    Text = GetTitle();
                    txtMain.Text = text;
                }
                catch (DirectoryNotFoundException)
                {
                    MessageBox.Show(@"指定されたディレクトリが存在しません。", AppConst.AppName,
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show(@"指定されたファイルが存在しません。", AppConst.AppName,
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (PathTooLongException)
                {
                    MessageBox.Show(@"指定されたファイルパスが長すぎます。", AppConst.AppName,
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show(@"指定されたファイルへのアクセスが許可されておりません。", AppConst.AppName,
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (IOException)
                {
                    MessageBox.Show(@"指定されたファイルを読み込むことができません。", AppConst.AppName,
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (OutOfMemoryException)
                {
                    MessageBox.Show(@"メモリ不足です。", AppConst.AppName,
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!HasOpenFile)
            {
                SaveAs();
                return;
            }
            WriteTextToOpenedFile();
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        private string GetTitle() => $@"{AppConst.AppName} - {OpenFileName}";

        private void Initialize()
        {
            txtMain.Text = "";
            OpenFilePath = "";
            Text = GetTitle();
        }

        private void SaveAs()
        {
            using (var dialog = new SaveFileDialog())
            {
                dialog.Filter = Filter;
                dialog.FilterIndex = 1;
                dialog.DefaultExt = "txt";

                var dialogResult = dialog.ShowDialog();
                if (dialogResult != DialogResult.OK)
                {
                    return;
                }

                OpenFilePath = dialog.FileName;
                WriteTextToOpenedFile();
                Text = GetTitle();
            }
        }

        private void WriteTextToOpenedFile()
        {
            try
            {
                File.WriteAllText(OpenFilePath, txtMain.Text, Encoding.GetEncoding("shift_jis"));
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show(@"指定されたディレクトリが存在しません。", AppConst.AppName,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (PathTooLongException)
            {
                MessageBox.Show(@"指定されたファイルパスが長すぎます。", AppConst.AppName,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show(@"指定されたファイルへのアクセスが許可されておりません。", AppConst.AppName,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (IOException)
            {
                MessageBox.Show(@"指定されたファイルに書き込むことができません。", AppConst.AppName,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}