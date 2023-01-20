namespace design_pattern.Adapter
{

    internal interface IFileWitter
    {
        void Write();
    }

    internal class JsonFileWitter : IFileWitter
    {
        public void Write()
        {
            Console.WriteLine("File.json");
        }
    }

    internal class CsvFileWitter : IFileWitter
    {
        public void Write()
        {
            Console.WriteLine("File.csv");
        }
    }
}
