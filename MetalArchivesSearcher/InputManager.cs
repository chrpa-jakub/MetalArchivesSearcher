using System;

namespace MetalArchivesSearcher
{
    public class InputManager
    {
        public string GetInputFileName()
        {
            Console.Write("Input file name: ");
            var inputFileName = Console.ReadLine()??"";
            return inputFileName.Contains(".txt") ? inputFileName : inputFileName+".txt";
        }

        public string GetOutputFileName()
        {
            Console.Write("Output file name: ");
            var outputFileNameRaw = Console.ReadLine()??"";
            var outputFileName = outputFileNameRaw.Contains(".txt") ? outputFileNameRaw : outputFileNameRaw + ".txt";
            return outputFileName == string.Empty ? $"Output_{new Random().Next()}.txt" : outputFileName;
        }
    }
}