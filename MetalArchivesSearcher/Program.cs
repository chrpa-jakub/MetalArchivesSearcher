using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MetalArchivesSearcher
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var inputManager = new InputManager();
            var fileManager = new FileManager(inputManager.GetInputFileName(), inputManager.GetOutputFileName());
            var dataScraper = new DataScraper();
            Console.Clear();
            Console.WriteLine("Running!");
            foreach (var bandName in fileManager.GetBandNames())
            {                    
                if (!await dataScraper.DoesExist(bandName.ToLower().Trim()))
                {
                    fileManager.OutputNameToFile(bandName);
                    Console.WriteLine("Found: "+bandName);
                }
            }
            Console.Clear();
            Console.WriteLine("Finished!");
        }
    }
}