using System;
using System.Collections;
using System.Collections.Generic;
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

        IList<string> OpenFiles { get; }

        bool HasOpenFile { get; }

        bool IsEdited { get; set; }

        Func<bool> CloseConfirm { get; set; }

        INotepadView Owner { get; }

        void AddContent();

        void SelectContent(string filePath);

        void CloseContent(bool allowContentsCountZero = false);

    }
}
