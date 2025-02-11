using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphicDesign.UI.Models;
using GraphicDesign.UI.Formatting;
using System.Globalization;

namespace GraphicDesign.DataAccounting.Studying
{
    public static class ModelsTraining
    {
        internal static void Run()
        {
            Console.WriteLine("=== ModelsTraining ===");
            StudyInstrumentModel();
            StudyIllustrationModel();


        }
        private static void StudyInstrumentModel()
        {
            Console.WriteLine("\n --- StudyInstrumentModel ---");

            //Дослідження класу Instrument           
            Instrument instrument1 = new Instrument();
            instrument1.ToolName = "Листок паперу";

            Console.WriteLine("ToolName1: " + instrument1.ToolName);
            Console.WriteLine("ToolName1: {0}", instrument1.ToolName);
            Console.WriteLine($"ToolName1: {instrument1.ToolName}");

            instrument1.ToolName = "ChatGPT plus";
            instrument1.Price = 20;
            instrument1.PaymentDate = DateTime.ParseExact("05/01/2025", "dd/mm/yyyy", CultureInfo.InvariantCulture);
            instrument1.Note = "preset";

            Console.WriteLine("instrument1:\n{0}", ModelsFormatting.ToDataString(instrument1));
            Console.WriteLine("instrument1:\n{0}", instrument1.ToDataString());

            Instrument instrument2 = new Instrument()
            {
                ToolName = "Midjourney",
                Price = 10,
                PaymentDate = DateTime.ParseExact("21/11/2024", "dd/mm/yyyy", CultureInfo.InvariantCulture),
                Note = "preset"
            };

            Console.WriteLine("instrument2:\n{0}", instrument2.ToDataString());
        }
        private static void StudyIllustrationModel()
        {
            Console.WriteLine("\n --- StudyIllustrationModel ---");
         
            //Дослідження інтерфейсу IImage
            Illustration illustration1 = new Illustration();
            illustration1.Name = "Кабанчик";

            Console.WriteLine("Name1: " + illustration1.Name);
            Console.WriteLine("Name1: {0}", illustration1.Name);
            Console.WriteLine($"Name1: {illustration1.Name}");

            illustration1.Name = "EcoWave";
            illustration1.FilePath = "./logos/Company_EcoWave.jpg";
            illustration1.CreationDate = DateTime.ParseExact("14/12/2024", "dd/mm/yyyy", CultureInfo.InvariantCulture);
            illustration1.Desctiption = "Prompt: Create a logo that combines the image of" +
                " a wave with eco-friendly elements (e.g., leaves, trees). Use natural green and blue colors.";
            illustration1.Note = "preset";

            Console.WriteLine("illustration1: {0}", ModelsFormatting.ToDataString(illustration1));
            Console.WriteLine("illustration1: {0}", illustration1.ToDataString());

            Illustration illustration2 = new Illustration()
            {
                Name = "TechNest",
                FilePath = "./logos/Company_EcoWave.jpg",
                CreationDate = DateTime.ParseExact("14/12/2024", "dd/mm/yyyy", CultureInfo.InvariantCulture),
                Desctiption = "Prompt: Design a modern, minimalist logo that combines technology and " +
                "innovation. Use clean lines and colors like blue or gray.",
                Note = "preset"
            };
            
            Console.WriteLine("illustration2: {0}", illustration2.ToDataString());
        }
    }
}
