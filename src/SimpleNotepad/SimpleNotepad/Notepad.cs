using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleNotepad
{
    public partial class Notepad : Form
    {
        /// <summary>
        /// <see cref="Notepad"/>の新しいインタンスを生成します。
        /// </summary>
        public Notepad()
        {
            InitializeComponent();

            //TODO:必要になったら抽象化 + DI
            //・タブあり    <=> なし
            //・TextBox     <=> RichTextBox
            //・ダイアログ  <=> 固定
            //_fileNameProvider = new FilePathProvider();
            //_contentsControl = new TabContentsControl(this);

            //_manager = new NotepadManager(this);
        }

    }
}
