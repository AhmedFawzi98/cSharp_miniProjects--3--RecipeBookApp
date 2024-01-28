using System;
namespace Classes.ProgramSettings
{
    public class AppMetaData
    {
        public AppMetaData(string fileName, RepositoryFileFormat fileFormat)
        {
            FileName = fileName;
            FileFormat = fileFormat;
        }
        private string FileName { get; init; }
        private RepositoryFileFormat FileFormat { get; init; }
        public string FilePath => $"{FileName}.{ToExtension(FileFormat)}";
        private string ToExtension(RepositoryFileFormat format) => (format == RepositoryFileFormat.json) ? "json": "txt";

    }
}
