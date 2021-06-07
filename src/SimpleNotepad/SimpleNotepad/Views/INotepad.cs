using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.Control;

namespace SimpleNotepad.Views
{
    /// <summary>
    /// 簡易メモ帳機能を提供します。
    /// </summary>
    public interface INotepad
    {
        /// <summary>
        /// 現在のタイトルを取得、設定します。
        /// </summary>
        string Title { get; set; }

        /// <summary>
        /// 現在の本文を取得、設定します。
        /// </summary>
        string Content { get; set; }

        /// <summary>
        /// 現在開いているファイルの名称を取得します。
        /// </summary>
        string OpenFileName { get; }

        /// <summary>
        /// 現在開いているファイルのパスを取得、設定します。
        /// </summary>
        string OpenFilePath { get; set; }

        /// <summary>
        /// 現在編集中かどうかを取得、設定します。
        /// 編集中の場合は true それ以外は false。
        /// </summary>
        bool IsEdited { get; set; }

        /// <summary>
        /// 現在開いているファイルがあるかを取得します。
        /// 現在開いているファイルがあれば true それ以外は false
        /// </summary>
        bool HasOpenFile { get; }

        /// <summary>
        /// 本文が変更された際に実行されるイベントハンドラーを取得します。
        /// </summary>
        EventHandler ContentChangedEventHandler { get; }

        /// <summary>
        /// コンテンツが閉じられた際に確認処理をおこなうデリゲートを取得します。
        /// </summary>
        Func<bool> CloseConfirm { get; }

        
        ControlCollection Controls { get; }
    }
}
