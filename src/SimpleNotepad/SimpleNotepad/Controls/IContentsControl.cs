using System;
using SimpleNotepad.Views;

namespace SimpleNotepad.Controls
{
    public interface IContentsControl
    {
        event EventHandler ContentChangedEventHandler;

        string Title { get; set; }

        string Content { get; set; }

        int ContentsCount { get; }

        string OpenFileName { get; }

        string OpenFilePath { get; set; }

        bool IsEdited { get; set; }

        int ContentAddedCount { get; }

        bool HasOpenFile { get; }

        void AddContent();

        void CloseContent(bool allowContentsCountZero = false);

        Func<bool> CloseConfirm { get; set; }

        INotepadView Owner { get; }
    }
}
