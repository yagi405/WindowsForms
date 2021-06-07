using SimpleNotepad.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleNotepad
{
    /// <summary>
    /// 簡易メモ帳のコンテンツ管理機能を提供します。
    /// </summary>
    /// <remarks>
    /// TODO:タブを利用しない場合の実装を用意し、
    /// 切り替え可能に(ex. タブ有り <=> タブ無し)
    /// </remarks>
    public interface IContentsControl
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
        /// コンテンツの数を取得します。
        /// </summary>
        int CountensCount { get; }

        /// <summary>
        /// 現在開いているファイルの名称を取得します。
        /// </summary>
        string OpenFileName { get; }

        /// <summary>
        /// 現在開いているファイルのパスを取得します。
        /// </summary>
        string OpenFilePath { get; set; }

        /// <summary>
        /// 現在編集中かどうかを取得、設定します。
        /// 編集中の場合は true それ以外は false。
        /// </summary>
        bool IsEdited { get; set; }

        /// <summary>
        /// コンテンツが追加された回数を取得します。
        /// </summary>
        int ContentAddedCount { get; }

        /// <summary>
        /// 現在開いているファイルがあるかを取得します。
        /// 現在開いているファイルがあれば true それ以外は false
        /// </summary>
        bool HasOpenFile { get; }

        /// <summary>
        /// コンテンツを追加します。
        /// </summary>
        void AddContent();

        /// <summary>
        /// 現在のコンテンツを閉じます。
        /// コンテンツの数が0になることを許容する場合は true それ以外は false
        /// </summary>
        /// <param name="allowContentsCountZero">
        /// 現在のコンテンツを閉じた結果、
        /// コンテンツの数が0になることを許容する場合は true それ以外は false
        /// </param>
        void CloseContent(bool allowContentsCountZero = false);

        /// <summary>
        /// 所属する簡易メモ帳を取得します。
        /// </summary>
        INotepad Owner { get; }
    }
}
