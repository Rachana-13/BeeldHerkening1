using System;
using System.Diagnostics;
using BeeldHerkening1ML.Model;
namespace BeeldHerkening1

{
    class Program
    {
        static void Main(string[] args)
        {
            Debug.WriteLine(" Object is not valid for this category.");
            // Add input data
            var input = new ModelInput();
            input.ImageSource = @"C:\Users\racha\Downloads\Machine Learning\images\Auto\Auto1.jpg";


            // Load model and predict output of sample data
            ModelOutput result = ConsumeModel.Predict(input);
            Debug.WriteLine(result.Prediction);
            Console.WriteLine(result.Prediction);
        }
    }
}
