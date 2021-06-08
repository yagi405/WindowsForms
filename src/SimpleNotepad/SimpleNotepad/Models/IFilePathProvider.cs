namespace SimpleNotepad.Models
{
    /// <summary>
    /// ファイルパスの取得機能を提供します。
    /// </summary>
    public interface IFilePathProvider
    {
        /// <summary>
        /// 開くファイルのパスを取得します。
        /// </summary>
        /// <returns>開くファイルのパス</returns>
        string GetOpenFilePath();

        /// <summary>
        /// 保存するファイルのパスを取得します。
        /// </summary>
        /// <returns>保存するファイルのパス</returns>
        string GetSaveFilePath();
    }
}
