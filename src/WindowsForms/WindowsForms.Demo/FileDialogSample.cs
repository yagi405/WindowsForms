using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms.Demo
{
    public partial class FileDialogSample : Form
    {
        public FileDialogSample()
        {
            InitializeComponent();
        }

        private void btnOpenFileDialog_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                var dialogResult = dialog.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    txtValue.Text = dialog.FileName;
                }
            }
        }

        private void SaveFileDialog_Click(object sender, EventArgs e)
        {
            using (var dialog = new SaveFileDialog())
            {
                var dialogResult = dialog.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    txtValue.Text = dialog.FileName;
                }
            }
        }
    }
}
