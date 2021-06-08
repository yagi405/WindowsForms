using System;
using System.Windows.Forms;

namespace SimpleNotepad.Views
{
    /// <summary>
    /// 置換ダイアログを示すクラスです。
    /// </summary>
    public partial class Replace : Form, IReplaceView
    {
        public event EventHandler LoadEventHandler
        {
            add => Load += value;
            remove => Load -= value;
        }

        public event EventHandler CancelClickEventHandler
        {
            add => btnCancel.Click += value;
            remove => btnCancel.Click -= value;
        }

        public event EventHandler ReplaceClickEventHandler
        {
            add => btnReplace.Click += value;
            remove => btnReplace.Click -= value;
        }

        public event EventHandler TargetTextChangedEventHandler
        {
            add => txtTarget.TextChanged += value;
            remove => txtTarget.TextChanged -= value;
        }

        public bool ReplaceEnabled
        {
            get => btnReplace.Enabled;
            set => btnReplace.Enabled = value;
        }

        /// <summary>
        /// <see cref="Replace"/>の新しいインスタンスを生成します。
        /// </summary>
        public Replace()
        {
            InitializeComponent();
            DialogResult = DialogResult.Abort;
        }

        /// <summary>
        /// 対象の文字列を取得します。
        /// </summary>
        public string Target => txtTarget.Text;

        /// <summary>
        /// 置換後の文字列を取得します。
        /// </summary>
        public string Replaced => txtReplaced.Text;

        /// <summary>
        /// 大文字と小文字を区別するか
        /// 区別する場合は true それ以外は false
        /// </summary>
        public bool CaseSensitive => chkCaseSensitive.Checked;
    }
}
