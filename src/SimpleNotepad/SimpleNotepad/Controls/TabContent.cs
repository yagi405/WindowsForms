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

        public string Title
        {
            get => Text;
            set => Text = value;
        }

        public string Content
        {
            get => _txtMain.Text;
            set => _txtMain.Text = value;
        }

        public event EventHandler ContentChangedEventHandler
        {
            add => _txtMain.TextChanged += value;
            remove => _txtMain.TextChanged -= value;
        }

        public bool IsEdited { get; set; }

        public string OpenFilePath { get; set; }

        public string OpenFileName => HasOpenFile
            ? Path.GetFileName(OpenFilePath)
            : _defaultFileName;

        public bool HasOpenFile => !string.IsNullOrEmpty(OpenFilePath);

        private TabContentsControl Owner { get; }

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
                Font = new Font("Yu Gothic UI", 10f, FontStyle.Regular),
                BorderStyle = BorderStyle.None,
                BackColor = Color.FloralWhite,
            };

            Controls.Add(_txtMain);
            Owner.Controls.Add(this);
        }
    }
}
