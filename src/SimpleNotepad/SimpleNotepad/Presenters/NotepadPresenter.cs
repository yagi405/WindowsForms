using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using SimpleNotepad.Models;
using SimpleNotepad.Views;

namespace SimpleNotepad.Presenters
{
    public class NotepadPresenter
    {
        private const string EditedSuffix = "(編集中)";

        private readonly INotepadView _notepad;

        private readonly IFilePathProvider _filePathProvider;

        private readonly IDisplayDialogService _displayDialogService;

        //Encodingの切替機能は未サポート
        private static readonly Encoding _encoding = Encoding.GetEncoding("Shift_JIS");

        public string Title => _notepad.OpenFileName + (_notepad.IsEdited ? EditedSuffix : "");

        public NotepadPresenter(INotepadView notepad, IFilePathProvider filePathProvider, IDisplayDialogService displayDialogService)
        {
            _notepad = notepad ?? throw new ArgumentNullException(nameof(notepad));
            _filePathProvider = filePathProvider ?? throw new ArgumentNullException(nameof(filePathProvider));
            _displayDialogService = displayDialogService ?? throw new ArgumentNullException(nameof(displayDialogService));

            _notepad.LoadEventHandler += OnLoad;
            _notepad.ContentChangedEventHandler += OnTextChanged;
            _notepad.OpenClickEventHandler += OnOpen;
            _notepad.SaveClickEventHandler += OnSave;
            _notepad.SaveAsClickEventHandler += OnSaveAs;
            _notepad.ReplaceClickEventHandler += Replace;
            _notepad.DragEnterEventHandler += OnDragEnter;
            _notepad.DragDropEventHandler += OnDragDrop;
            _notepad.FormClosingEventHandler += OnFormClosing;

            _notepad.CloseConfirm = ConfirmSave;
        }

        private void OnOpen(object sender, EventArgs e)
        {
            var filePath = _filePathProvider.GetOpenFilePath();

            if (string.IsNullOrEmpty(filePath))
            {
                return;
            }

            Open(filePath);
        }

        private void Open(string filePath)
        {
            try
            {
                var contents = Read(filePath);
                _notepad.OpenFilePath = filePath;
                FixContents(contents);
            }
            catch (DirectoryNotFoundException)
            {
                _displayDialogService.ShowError("指定されたディレクトリが存在しません。");
            }
            catch (FileNotFoundException)
            {
                _displayDialogService.ShowError("指定されたファイルが存在しません。");
            }
            catch (PathTooLongException)
            {
                _displayDialogService.ShowError("指定されたファイルパスが長すぎます。");
            }
            catch (UnauthorizedAccessException)
            {
                _displayDialogService.ShowError("指定されたファイルへのアクセスが許可されておりません。");
            }
            catch (IOException)
            {
                _displayDialogService.ShowError("指定されたファイルを読み込むことができません。");
            }
            catch (OutOfMemoryException)
            {
                _displayDialogService.ShowError("メモリ不足です。");
            }
        }

        /// <summary>
        /// 現在開いているファイルを上書き保存します。
        /// </summary>
        private void OnSave(object sender, EventArgs e)
        {
            Save();
        }

        private void OnSaveAs(object sender, EventArgs e)
        {
            SaveAs();
        }

        private bool Save()
        {
            if (!_notepad.HasOpenFile)
            {
                return SaveAs();
            }

            try
            {
                OverWriteSave();
                return true;
            }
            catch (DirectoryNotFoundException)
            {
                _displayDialogService.ShowError("指定されたディレクトリが存在しません。");
            }
            catch (PathTooLongException)
            {
                _displayDialogService.ShowError("指定されたファイルパスが長すぎます。");
            }
            catch (UnauthorizedAccessException)
            {
                _displayDialogService.ShowError("指定されたファイルへのアクセスが許可されておりません。");
            }
            catch (IOException)
            {
                _displayDialogService.ShowError("指定されたファイルに書き込むことができません。");
            }

            return false;
        }

        private void OverWriteSave()
        {
            if (!_notepad.HasOpenFile)
            {
                throw new InvalidOperationException("上書き保存対象のファイルが存在しません。");
            }

            Write(_notepad.OpenFilePath);
            FixContents();
        }

        private bool SaveAs()
        {
            var filePath = _filePathProvider.GetSaveFilePath();
            if (string.IsNullOrEmpty(filePath))
            {
                return false;
            }

            try
            {
                Write(filePath);
                _notepad.OpenFilePath = filePath;
                FixContents();
                return true;
            }
            catch (DirectoryNotFoundException)
            {
                _displayDialogService.ShowError("指定されたディレクトリが存在しません。");
            }
            catch (PathTooLongException)
            {
                _displayDialogService.ShowError("指定されたファイルパスが長すぎます。");
            }
            catch (UnauthorizedAccessException)
            {
                _displayDialogService.ShowError("指定されたファイルへのアクセスが許可されておりません。");
            }
            catch (IOException)
            {
                _displayDialogService.ShowError("指定されたファイルに書き込むことができません。");
            }

            return false;
        }

        public void Replace(object sender, EventArgs e)
        {
            var (dr, target, replaced, caseSensitive) = _displayDialogService.ShowReplaceDialog();

            if (dr == DialogResult.Cancel)
            {
                return;
            }

            _notepad.Content = Regex.Replace(_notepad.Content, target, replaced,
                caseSensitive ? RegexOptions.None : RegexOptions.IgnoreCase);
        }

        public void OnTextChanged(object sender, EventArgs e)
        {
            if (_notepad.IsEdited)
            {
                return;
            }
            _notepad.IsEdited = true;
            _notepad.Title = Title;
        }

        private void FixContents(string contents)
        {
            _notepad.Content = contents;
            FixContents();
        }

        private void FixContents()
        {
            _notepad.IsEdited = false;
            _notepad.Title = Title;
        }

        private void Write(string filePath)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                throw new ArgumentException(@"ファイルパスを null 又は 空文字 にすることはできません。", nameof(filePath));
            }

            File.WriteAllText(filePath, _notepad.Content, _encoding);
        }

        private string Read(string filePath)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                throw new ArgumentException(@"ファイルパスを null 又は 空文字 にすることはできません。", nameof(filePath));
            }

            return File.ReadAllText(filePath, _encoding);
        }

        private bool ConfirmSave()
        {
            if (!_notepad.IsEdited)
            {
                return true;
            }

            var dr = _displayDialogService.ShowYesNoCancelDialog($"{_notepad.OpenFileName}を保存しますか？");

            switch (dr)
            {
                case DialogResult.Yes:
                    return Save();
                default:
                    return dr == DialogResult.No;
            }
        }

        private void OnLoad(object sender, EventArgs e)
        {
            var args = Environment.GetCommandLineArgs();

            if (args.Length < 2 || string.IsNullOrEmpty(args[1]))
            {
                return;
            }

            for (var i = 1; i < args.Length; i++)
            {
                Open(args[i]);
                if (args.Length - 1 == i)
                {
                    break;
                }
                _notepad.AddContent();
            }
        }


        public void OnFormClosing(object sender, CancelEventArgs e)
        {
            for (var i = 0; i < _notepad.ContentsCount; i++)
            {
                e.Cancel = !_notepad.CloseConfirm();
                if (e.Cancel)
                {
                    break;
                }
                _notepad.CloseContent();
            }
        }

        private void OnDragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop)
                ? DragDropEffects.All
                : DragDropEffects.None;
        }

        private void OnDragDrop(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                return;
            }

            if (!(e.Data.GetData(DataFormats.FileDrop) is string[] filePaths) || !filePaths.Any())
            {
                return;
            }

            foreach (var t in filePaths)
            {
                if (string.IsNullOrEmpty(t))
                {
                    continue;
                }
                _notepad.AddContent();
                Open(t);
            }
        }
    }
}