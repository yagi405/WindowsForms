using System;
using System.Windows.Forms;

namespace SimpleNotepad.Views
{
    public interface IReplaceView
    {
        event EventHandler LoadEventHandler;

        event EventHandler CancelClickEventHandler;

        event EventHandler ReplaceClickEventHandler;

        event EventHandler TargetTextChangedEventHandler;

        string Target { get; }

        string Replaced { get; }

        bool CaseSensitive { get; }

        bool ReplaceEnabled { get; set; }

        DialogResult DialogResult { get; set; }
    }
}
