using System;
using SampleClassification.Model;

namespace consumeModelApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Add input data
            var input = new ModelInput();
            Console.WriteLine("Please, Write a phrase to analize it and provide a sentiment");
            input.SentimentText = Console.ReadLine();

            // Load model and predict output of sample data
            ModelOutput result = ConsumeModel.Predict(input);
            for (int i = 0; i < result.Score.Length; i++)
            {
                Console.WriteLine($"\nScore: {result.Score[i]}\nI: {i}");
            }
            Console.WriteLine($"Text: {input.SentimentText}\nIs Toxic: {result.Prediction}");
        }
    }
}

