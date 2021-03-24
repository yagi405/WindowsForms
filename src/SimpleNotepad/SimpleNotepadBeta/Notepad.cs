using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SimpleNotepadBeta
{
    public partial class Notepad : Form
    {
        private const string DefaultFileName = "(無題)";
        private const string EditedSuffix = "(編集中)";
        private const string Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

        public string OpenFilePath { get; private set; }

        public bool HasOpenFile => !string.IsNullOrEmpty(OpenFilePath);

        public string OpenFileName => HasOpenFile
            ? Path.GetFileName(OpenFilePath)
            : DefaultFileName;

        public string Body => txtMain.Text;

        public bool IsEdited { get; private set; }

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
            if (!AskToSave())
            {
                return;
            }

            Initialize();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (!AskToSave())
            {
                return;
            }

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
                    //TODO:ちらつき防止
                    var text = File.ReadAllText(OpenFilePath);
                    txtMain.Text = text;
                    IsEdited = false;
                    AdjustTitle();
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
            Save();
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            SaveAs();
        }
        private void txtMain_TextChanged(object sender, EventArgs e)
        {
            IsEdited = true;
            AdjustTitle();
        }

        private void Notepad_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !AskToSave();
        }
        private void btnReplace_Click(object sender, EventArgs e)
        {
            var replaceDialog = new Replace();
            var dialogResult = replaceDialog.ShowDialog(this);

            if (dialogResult == DialogResult.Cancel)
            {
                return;
            }

            txtMain.Text = Regex.Replace(txtMain.Text, replaceDialog.Old, replaceDialog.New,
                replaceDialog.CaseSensitive ? RegexOptions.None : RegexOptions.IgnoreCase);
        }

        private bool AskToSave()
        {
            if (!IsEdited)
            {
                return true;
            }

            var dialogResult = MessageBox.Show($@"{OpenFileName} を保存しますか？", AppConst.AppName,
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (dialogResult != DialogResult.Yes)
            {
                return dialogResult == DialogResult.No;
            }

            return Save();
        }

        private void AdjustTitle() => Text = $@"{AppConst.AppName} - {OpenFileName}{(IsEdited ? EditedSuffix : "")}";

        private void Initialize()
        {
            txtMain.Text = "";
            OpenFilePath = "";
            IsEdited = false;
            AdjustTitle();
        }

        private bool Save()
        {
            if (!HasOpenFile)
            {
                return SaveAs();
            }
            WriteTextToOpenedFile();
            IsEdited = false;
            AdjustTitle();
            return true;
        }

        private bool SaveAs()
        {
            using (var dialog = new SaveFileDialog())
            {
                dialog.Filter = Filter;
                dialog.FilterIndex = 1;
                dialog.DefaultExt = "txt";

                var dialogResult = dialog.ShowDialog();
                if (dialogResult != DialogResult.OK)
                {
                    return false;
                }

                OpenFilePath = dialog.FileName;
                WriteTextToOpenedFile();
                IsEdited = false;
                AdjustTitle();
                return true;
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