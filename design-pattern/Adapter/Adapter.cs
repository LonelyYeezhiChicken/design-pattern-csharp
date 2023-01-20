namespace design_pattern.Adapter
{

    internal static class FileTool
    {
        public static IFileTool Factory(string fileType)
        {
            return fileType switch
            {
                "json" => new Adapter(new JsonFileWitter()),
                "csv" => new Adapter(new CsvFileWitter()),
                _ => throw new ArgumentException($"上未實做 {fileType}"),
            };
        }
    }


    internal interface IFileTool
    {
        void Create();
    }


    internal class Adapter : IFileTool
    {
        private readonly IFileWitter _tool;

        public Adapter(IFileWitter tool)
        {
            _tool = tool;
        }

        public void Create()
        {
            _tool.Write();
        }
    }
}
