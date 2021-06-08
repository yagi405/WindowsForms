using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using SimpleNotepad.Controls;

namespace SimpleNotepad.Views
{
    public partial class Notepad : Form, INotepadView
    {
        private readonly IContentsControl _contentsControl;

        public event EventHandler LoadEventHandler
        {
            add => Load += value;
            remove => Load -= value;
        }

        public event EventHandler ContentChangedEventHandler
        {
            add => _contentsControl.ContentChangedEventHandler += value;
            remove => _contentsControl.ContentChangedEventHandler -= value;
        }

        public event EventHandler OpenClickEventHandler
        {
            add => mnuOpen.Click += value;
            remove => mnuOpen.Click -= value;
        }

        public event EventHandler SaveClickEventHandler
        {
            add
            {
                btnSave.Click += value;
                mnuSave.Click += value;
            }
            remove
            {
                btnSave.Click -= value;
                mnuSave.Click -= value;
            }
        }

        public event EventHandler SaveAsClickEventHandler
        {
            add => mnuSaveAs.Click += value;
            remove => mnuSaveAs.Click -= value;
        }

        public event EventHandler ReplaceClickEventHandler
        {
            add
            {
                btnReplace.Click += value;
                mnuReplace.Click += value;
            }
            remove
            {
                btnReplace.Click -= value;
                mnuReplace.Click -= value;
            }
        }

        public event DragEventHandler DragEnterEventHandler
        {
            add => DragEnter += value;
            remove => DragEnter -= value;
        }

        public event DragEventHandler DragDropEventHandler
        {
            add => DragDrop += value;
            remove => DragDrop -= value;
        }

        public event CancelEventHandler FormClosingEventHandler
        {
            add => Closing += value;
            remove => Closing -= value;
        }

        public string Title
        {
            get => _contentsControl.Title;
            set => _contentsControl.Title = value;
        }

        public string Content
        {
            get => _contentsControl.Content;
            set => _contentsControl.Content = value;
        }

        public int ContentsCount => _contentsControl.ContentsCount;
        public string OpenFilePath
        {
            get => _contentsControl.OpenFilePath;
            set => _contentsControl.OpenFilePath = value;
        }

        public string OpenFileName => _contentsControl.OpenFileName;

        public IList<string> OpenFiles => _contentsControl.OpenFiles;

        public bool HasOpenFile => _contentsControl.HasOpenFile;

        public bool IsEdited
        {
            get => _contentsControl.IsEdited;
            set => _contentsControl.IsEdited = value;
        }

        public Func<bool> CloseConfirm
        {
            get => _contentsControl.CloseConfirm;
            set => _contentsControl.CloseConfirm = value;
        }

        public void AddContent()
        {
            _contentsControl.AddContent();
        }

        public void SelectContent(string filePath)
        {
            _contentsControl.SelectContent(filePath);
        }

        public void CloseContent(bool allowContentsCountZero = false)
        {
            _contentsControl.CloseContent(allowContentsCountZero);
        }

        public Notepad()
        {
            InitializeComponent();
            _contentsControl = new TabContentsControl(this);
            mnuNew.Click += (sender, args) => _contentsControl.AddContent();
            mnuClose.Click += (sender, args) => _contentsControl.CloseContent();
        }
    }
}
