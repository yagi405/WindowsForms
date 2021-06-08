using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace SimpleNotepad.Views
{
    /// <summary>
    /// 簡易メモ帳機能を提供します。
    /// </summary>
    public interface INotepadView : IDisposable
    {
        event EventHandler ContentChangedEventHandler;

        event EventHandler LoadEventHandler;

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

        int ContentAddedCount { get; }

        string OpenFileName { get; }

        string OpenFilePath { get; set; }

        bool IsEdited { get; set; }

        bool HasOpenFile { get; }

        void AddContent();

        void CloseContent(bool allowContentsCountZero = false);

        Func<bool> CloseConfirm { get; set; }

        //void OnFormClosing(object sender, CancelEventArgs e);

        Control.ControlCollection Controls { get; }

    }
}
