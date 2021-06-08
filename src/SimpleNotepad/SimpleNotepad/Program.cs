using System;
using System.Windows.Forms;
using SimpleNotepad.Models;
using SimpleNotepad.Presenters;
using SimpleNotepad.Util;
using SimpleNotepad.Views;

namespace SimpleNotepad
{
    internal static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        private static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                using (var notepadView = new Notepad())
                {
                    notepadView.Tag = new NotepadPresenter(notepadView, new FilePathProvider(), new DisplayDialogService());
                    Application.Run(notepadView);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                    $@"予期せぬエラーが発生しました。
{AppConst.AppName}を終了します。",
                    AppConst.AppName,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                Application.Exit();
            }
        }
    }
}