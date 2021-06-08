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

        int ContentAddedCount { get; }

        string OpenFilePath { get; set; }

        string OpenFileName { get; }

        bool HasOpenFile { get; }

        bool IsEdited { get; set; }

        Func<bool> CloseConfirm { get; set; }

        INotepadView Owner { get; }

        void AddContent();

        void CloseContent(bool allowContentsCountZero = false);

    }
}
