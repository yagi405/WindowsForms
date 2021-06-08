using System;
using System.Windows.Forms;

namespace SimpleNotepad.Views
{
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

        public Replace()
        {
            InitializeComponent();
            DialogResult = DialogResult.Abort;
        }

        public string Target => txtTarget.Text;

        public string Replaced => txtReplaced.Text;

        public bool CaseSensitive => chkCaseSensitive.Checked;
    }
}
