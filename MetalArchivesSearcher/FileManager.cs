using System.IO;

namespace MetalArchivesSearcher
{
    public class FileManager
    {
        public FileManager(string inputFile, string outputFile)
        {
            _inputFile = inputFile;
            _outputFile = outputFile;
        }

        private string _inputFile;
        private string _outputFile;

        public string[] GetBandNames()
        {
            return File.ReadAllLines(_inputFile);
        }

        public void OutputNameToFile(string bandName)
        {
            File.AppendAllText(_outputFile,bandName+"\n");
        }
    }
}