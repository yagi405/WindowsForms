using SimpleNotepad.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SimpleNotepad.Models;

namespace SimpleNotepad.Controls
{
    public sealed class TabContentsControl : TabControl, IContentsControl
    {
        private const string DefaultName = "tabMain";

        private readonly IList<TabContent> _contents;

        private TabContent _selectedContent;

        public event EventHandler ContentChangedEventHandler;

        public string Title
        {
            get => _selectedContent.Title;
            set => _selectedContent.Title = value;
        }

        public string Content
        {
            get => _selectedContent.Content;
            set => _selectedContent.Content = value;
        }

        public int ContentsCount => TabCount;

        public string OpenFileName => _selectedContent.OpenFileName;

        public string OpenFilePath
        {
            get => _selectedContent.OpenFilePath;
            set => _selectedContent.OpenFilePath = value;
        }

        public bool IsEdited
        {
            get => _selectedContent.IsEdited;
            set => _selectedContent.IsEdited = value;
        }

        public int ContentAddedCount { get; private set; }

        public bool HasOpenFile => _selectedContent.HasOpenFile;

        public INotepadView Owner { get; }

        public TabContentsControl(INotepadView owner)
        {
            Owner = owner ?? throw new ArgumentNullException(nameof(owner));

            Name = DefaultName;
            Dock = DockStyle.Fill;
            SelectedIndexChanged += OnSelectedIndexChanged;
            _contents = new List<TabContent>();
            AddContent();

            Owner.Controls.Add(this);
            BringToFront();
        }

        public void AddContent()
        {
            var content = new TabContent(this)
            {
                ContentChangedEventHandler = ContentChangedEventHandler,
            };

            _contents.Add(content);
            _selectedContent = content;

            SelectedIndex = TabCount - 1;
            MouseClick += OnMouseClick;

            ContentAddedCount++;
        }

        public void CloseContent(bool allowContentsCountZero = false)
        {
            var removedIndex = SelectedIndex;

            if (!allowContentsCountZero && TabCount == 1)
            {
                AddContent();
            }

            if (TabCount != 1)
            {
                var destIndex = TabCount - 1 == removedIndex
                    ? removedIndex - 1  //末尾のタブである場合は前の要素を選択
                    : removedIndex + 1; //それ以外は次の要素を選択

                SelectedIndex = destIndex;
                _selectedContent = _contents[destIndex];
            }

            _contents.RemoveAt(removedIndex);
            TabPages.Remove(TabPages[removedIndex]);
        }

        public Func<bool> CloseConfirm { get; set; }

        private void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedContent = _contents[SelectedIndex];
        }

        private void OnMouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
            {
                return;
            }

            //クリックされた位置と各タブの位置を比較し、対象のタブを特定する
            for (int i = 0; i < TabCount; i++)
            {
                var r = GetTabRect(i);
                if (r.Contains(e.Location))
                {
                    SelectedIndex = i;

                    //現在サポートしているのは「閉じる」機能のみ
                    var contextMenuStrip = new ContextMenuStrip();
                    var item = new ToolStripMenuItem("閉じる");
                    item.Click += OnClose;
                    contextMenuStrip.Items.Add(item);
                    contextMenuStrip.Show(this, e.Location);
                    break;
                }
            }
        }

        private void OnClose(object sender, EventArgs e)
        {
            if (!CloseConfirm())
            {
                return;
            }
            CloseContent();
        }

    }
}