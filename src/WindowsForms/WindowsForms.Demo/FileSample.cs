using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms.Demo
{
    public partial class FileSample : Form
    {
        public FileSample()
        {
            InitializeComponent();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            var filePath = "sample.txt";

            //実際には try catch が必要

            File.WriteAllText(filePath, $"{txtValue.Text}\r\n", Encoding.GetEncoding("shift_jis"));
            File.AppendAllText(filePath, DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), Encoding.GetEncoding("shift_jis"));

            MessageBox.Show("書き込みが完了しました。");
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            var filePath = "sample.txt";

            //実際には try catch が必要

            var value = File.ReadAllText(filePath, Encoding.GetEncoding("shift_jis"));

            MessageBox.Show(value);
        }
    }
}
