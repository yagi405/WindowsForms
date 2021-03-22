using System;
using System.Windows.Forms;

namespace SimpleNotepadAlpha
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Notepad());
            }
            catch (Exception)
            {
                MessageBox.Show($@"予期せぬエラーが発生しました。\r\n{AppConst.AppName}を終了します。", AppConst.AppName,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
    }
}
