using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SimpleNotepad.Controls
{
    public sealed class TabContent : TabPage
    {
        private const string DefaultName = "tabPage";
        private const string DefaultFileName = "無題";
        private const string DefaultTextBoxName = "txtMain";

        private readonly TextBox _txtMain;
        private readonly string _defaultFileName;

        /// <summary>
        /// タイトルを取得、設定します。
        /// </summary>
        public string Title
        {
            get => Text;
            set => Text = value;
        }

        /// <summary>
        /// 本文を取得、設定します。
        /// </summary>
        public string Content
        {
            get => _txtMain.Text;
            set => _txtMain.Text = value;
        }

        /// <summary>
        /// 編集中かどうかを取得、設定します。
        /// 編集中の場合は true それ以外は false。
        /// </summary>
        public bool IsEdited { get; set; }

        /// <summary>
        /// 開いているファイルの名称を取得します。
        /// </summary>
        public string OpenFileName => HasOpenFile
            ? Path.GetFileName(OpenFilePath)
            : _defaultFileName;

        /// <summary>
        /// 開いているファイルのパスを取得、設定します。
        /// </summary>
        public string OpenFilePath { get; set; }

        /// <summary>
        /// 開いているファイルがあるかを取得します。
        /// 開いているファイルがあれば true それ以外は false
        /// </summary>
        public bool HasOpenFile => !string.IsNullOrEmpty(OpenFilePath);

        /// <summary>
        /// 本文が変更された際に実行されるイベントハンドラーを取得します。
        /// </summary>
        public EventHandler ContentChangedEventHandler
        {
            set => _txtMain.TextChanged += value;
        }

        /// <summary>
        /// 所属する<see cref="TabContentsControl"/>を取得します。
        /// </summary>
        private TabContentsControl Owner { get; }

        /// <summary>
        /// <see cref="TabContent"/>の新しいインスタンスを生成します。
        /// </summary>
        /// <param name="owner">所属する<see cref="TabContentsControl"/></param>
        public TabContent(TabContentsControl owner)
        {
            Owner = owner ?? throw new ArgumentNullException(nameof(owner));

            Owner = owner;
            var tabCount = Owner.ContentAddedCount + 1;
            Name = $"{DefaultName}{tabCount}";
            _defaultFileName = $"{DefaultFileName}{tabCount}";
            Text = _defaultFileName;

            _txtMain = new TextBox()
            {
                Name = $"{DefaultTextBoxName}{tabCount}",
                Multiline = true,
                Dock = DockStyle.Fill,
                AcceptsReturn = true,
                AcceptsTab = true,
                WordWrap = false,
                ScrollBars = ScrollBars.Both,
                Font = new Font("Yu Gothic UI", 12f, FontStyle.Regular),
                BorderStyle = BorderStyle.None,
                BackColor = Color.FloralWhite,
            };

            Controls.Add(_txtMain);

            Owner.Controls.Add(this);
        }
    }
}
