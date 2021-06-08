namespace SimpleNotepad.Models
{
    public interface IFilePathProvider
    {
        string GetOpenFilePath();

        string GetSaveFilePath();
    }
}
