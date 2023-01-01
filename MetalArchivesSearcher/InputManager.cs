using System;

namespace MetalArchivesSearcher
{
    public class InputManager
    {
        public string GetInputFileName()
        {
            Console.Write("Input file name: ");
            var inputFileName = Console.ReadLine()??"";
            return inputFileName;
        }

        public string GetOutputFileName()
        {
            Console.Write("Output file name: ");
            var outputFileNameRaw = Console.ReadLine()??"";
            var outputFileName = outputFileNameRaw;
            return outputFileName == string.Empty ? $"Output_{new Random().Next()}.txt" : outputFileName;
        }
    }
}
