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

        /// <summary>
        /// 対象の文字列を取得します。
        /// </summary>
        string Target { get; }

        /// <summary>
        /// 置換後の文字列を取得します。
        /// </summary>
        string Replaced { get; }

        /// <summary>
        /// 大文字と小文字を区別するか
        /// 区別する場合は true それ以外は false
        /// </summary>
        bool CaseSensitive { get; }

        bool ReplaceEnabled { get; set; }

        DialogResult DialogResult { get; set; }
    }
}
