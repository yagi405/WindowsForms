using System;
using System.Linq;
using System.Windows.Forms;
using SimpleNotepad.Views;

namespace SimpleNotepad.Presenters
{
    public class ReplacePresenter
    {
        private readonly IReplaceView _replaceView;

        public ReplacePresenter(IReplaceView replaceView)
        {
            _replaceView = replaceView ?? throw new ArgumentNullException(nameof(replaceView));
            _replaceView.LoadEventHandler += OnLoad;
            _replaceView.CancelClickEventHandler += OnCancelClick;
            _replaceView.TargetTextChangedEventHandler += OnTargetTextChanged;
            _replaceView.ReplaceClickEventHandler += OnReplaceClick;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            _replaceView.ReplaceEnabled = false;
        }

        private void OnCancelClick(object sender, EventArgs e)
        {
            _replaceView.DialogResult = DialogResult.Cancel;
        }

        private void OnReplaceClick(object sender, EventArgs e)
        {
            _replaceView.DialogResult = DialogResult.OK;
        }

        private void OnTargetTextChanged(object sender, EventArgs e)
        {
            _replaceView.ReplaceEnabled = _replaceView.Target.Any();
        }
    }
}
