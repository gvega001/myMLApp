using System;
using MyMLAppML.Model;

namespace myMLApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the comment:");
            string line;
            while ((line = Console.ReadLine()) != null)
            {
                string newLine = line.Replace(("").PadRight(0, ' '), "\t");
                Console.WriteLine(newLine);
            }

            // Create single instance of sample data from first line of dataset for model input
            ModelInput sampleData = new ModelInput()
            {
                Col0 = line,
            };

            // Make a single prediction on the sample data and print results
            var predictionResult = ConsumeModel.Predict(sampleData);

            Console.WriteLine("Using model to make single prediction -- Comparing actual Col1 with predicted Col1 from sample data...\n\n");
            Console.WriteLine($"Col0: {sampleData.Col0}");
            Console.WriteLine($"\n\nPredicted Col1 value {predictionResult.Prediction} \nPredicted Col1 scores: [{String.Join(",", predictionResult.Score)}]\n\n");
            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            Console.ReadKey();
        }
    }
}
