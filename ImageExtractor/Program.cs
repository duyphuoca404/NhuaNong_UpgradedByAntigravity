using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Resources;

namespace ImageExtractor
{
    class Program
    {
        static void Main(string[] args)
        {
            string resxPath = @"..\NhuaNong\ResourceNhua.resx";
            string outputDir = @"..\NhuaNong.Wpf\Assets\Images";

            if (!File.Exists(resxPath))
            {
                Console.WriteLine($"Error: Resx file not found at {resxPath}");
                return;
            }

            if (!Directory.Exists(outputDir))
            {
                Directory.CreateDirectory(outputDir);
            }

            Console.WriteLine($"Reading resources from {resxPath}...");

            using (ResXResourceReader reader = new ResXResourceReader(resxPath))
            {
                foreach (DictionaryEntry entry in reader)
                {
                    string key = entry.Key.ToString();
                    object value = entry.Value;

                    if (value is Bitmap bitmap)
                    {
                        string fileName = Path.Combine(outputDir, key + ".png");
                        try
                        {
                            bitmap.Save(fileName, ImageFormat.Png);
                            Console.WriteLine($"Saved: {fileName}");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Failed to save {key}: {ex.Message}");
                        }
                    }
                    else if (value is Icon icon)
                    {
                         string fileName = Path.Combine(outputDir, key + ".ico");
                         try
                         {
                             using (FileStream fs = new FileStream(fileName, FileMode.Create))
                             {
                                 icon.Save(fs);
                             }
                             Console.WriteLine($"Saved Icon: {fileName}");
                         }
                         catch(Exception ex)
                         {
                             Console.WriteLine($"Failed to save icon {key}: {ex.Message}");
                         }
                    }
                }
            }
            Console.WriteLine("Extraction complete.");
        }
    }
}
