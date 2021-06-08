using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace SimpleNotepad.Views
{
    /// <summary>
    /// 簡易メモ帳機能を提供します。
    /// </summary>
    public interface INotepadView : IDisposable
    {
        event EventHandler LoadEventHandler;

        event EventHandler ContentChangedEventHandler;

        event EventHandler OpenClickEventHandler;

        event EventHandler SaveClickEventHandler;

        event EventHandler SaveAsClickEventHandler;

        event EventHandler ReplaceClickEventHandler;

        event DragEventHandler DragEnterEventHandler;

        event DragEventHandler DragDropEventHandler;

        event CancelEventHandler FormClosingEventHandler;

        string Title { get; set; }

        string Content { get; set; }

        int ContentsCount { get; }

        string OpenFilePath { get; set; }

        string OpenFileName { get; }

        IList<string> OpenFiles { get; }

        bool HasOpenFile { get; }

        bool IsEdited { get; set; }

        Func<bool> CloseConfirm { get; set; }

        Control.ControlCollection Controls { get; }

        void AddContent();

        void SelectContent(string filePath);

        void CloseContent(bool allowContentsCountZero = false);
    }
}
