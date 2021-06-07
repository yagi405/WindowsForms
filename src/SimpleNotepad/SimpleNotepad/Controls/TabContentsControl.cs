using SimpleNotepad.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SimpleNotepad.Controls
{
    /// <summary>
    /// 簡易メモ帳のコンテンツ管理機能を有する<see cref="TabControl"/>です。
    /// 本クラスではコンテンツを<see cref="TabContent"/>のインタンスとして扱います。
    /// </summary>
    /// <remarks>
    /// TODO:<see cref="TabContent"/>を抽象化し、
    /// 切り替え可能に(ex. TextBox <=> RichTextBox)
    /// </remarks>
    public class TabContentsControl : TabControl, IContentsControl
    {
        private const string DefaultName = "tabMain";

        private readonly IList<TabContent> _contents;

        private readonly EventHandler _contentChanged;

        private readonly Func<bool> _closeConfirm;

        private TabContent _selectedContent;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public string Title
        {
            get => _selectedContent.Title;
            set => _selectedContent.Title = value;
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public string Content
        {
            get => _selectedContent.Content;
            set => _selectedContent.Content = value;
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public int CountensCount => TabCount;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public string OpenFileName => _selectedContent.OpenFileName;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public string OpenFilePath
        {
            get => _selectedContent.OpenFilePath;
            set => _selectedContent.OpenFilePath = value;
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public bool IsEdited
        {
            get => _selectedContent.IsEdited;
            set => _selectedContent.IsEdited = value;
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public int ContentAddedCount { get; private set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public bool HasOpenFile => _selectedContent.HasOpenFile;

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public INotepad Owner { get; }

        /// <summary>
        /// <see cref="TabContentsControl"/>の新しいインスタンスを生成します。
        /// </summary>
        /// <param name="owner">所属する簡易メモ帳</param>
        public TabContentsControl(INotepad owner)
        {
            Owner = owner ?? throw new ArgumentNullException(nameof(owner));
            _contentChanged += Owner.ContentChangedEventHandler;
            _closeConfirm = Owner.CloseConfirm;

            Name = DefaultName;
            Dock = DockStyle.Fill;
            SelectedIndexChanged += tabMain_SelectedIndexChanged;
            _contents = new List<TabContent>();
            AddContent();

            Owner.Controls.Add(this);
            BringToFront();
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public void AddContent()
        {
            var content = new TabContent(this)
            {
                ContentChangedEventHandler = _contentChanged,
            };

            _contents.Add(content);
            _selectedContent = content;

            SelectedIndex = TabCount - 1;
            MouseClick += tabMain_MouseClick;

            ContentAddedCount++;
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        public void CloseContent(bool allowContensCountZero = false)
        {
            var removedIndex = SelectedIndex;

            if (!allowContensCountZero && TabCount == 1)
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

        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedContent = _contents[SelectedIndex];
        }

        private void tabMain_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //クリックされた位置と各タブの位置を比較し、対象のタブを特定する
                for (int i = 0; i < TabCount; i++)
                {
                    var r = GetTabRect(i);
                    if (r.Contains(e.Location))
                    {
                        SelectedIndex = i;

                        //TODO:機能拡張
                        //現在サポートしているのは「閉じる」機能のみ
                        var contextMenuStrip = new ContextMenuStrip();
                        var item = new ToolStripMenuItem("閉じる");
                        item.Click += tsmiClose_Click;
                        contextMenuStrip.Items.Add(item);
                        contextMenuStrip.Show(this, e.Location);
                        break;
                    }
                }
            }
        }

        private void tsmiClose_Click(object sender, EventArgs e)
        {
            if (!_closeConfirm())
            {
                return;
            }
            CloseContent();
        }
    }
}