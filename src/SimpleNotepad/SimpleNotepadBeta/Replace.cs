using System;
using System.Linq;
using System.Windows.Forms;

namespace SimpleNotepadBeta
{
    public partial class Replace : Form
    {
        public string Old => txtOld.Text;
        public string New => txtNew.Text;
        public bool CaseSensitive => chkCaseSensitive.Checked;

        public Replace()
        {
            InitializeComponent();
        }

        private void Replace_Load(object sender, EventArgs e)
        {
            btnReplace.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            if (Owner is Notepad notepad)
            {
                if (notepad.Body.IndexOf(txtOld.Text, chkCaseSensitive.Checked
                    ? StringComparison.InvariantCulture
                    : StringComparison.InvariantCultureIgnoreCase) == -1)
                {
                    MessageBox.Show($@"{txtOld.Text} が見つかりません。", AppConst.AppName,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }
            }
            DialogResult = DialogResult.OK;
        }

        private void txtOld_TextChanged(object sender, EventArgs e)
        {
            btnReplace.Enabled = txtOld.Text.Any();
        }
    }
}
