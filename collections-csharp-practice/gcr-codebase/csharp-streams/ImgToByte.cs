using System;
using System.IO;

class ImgToByte
{
    static void Main()
    {
        string sourceImage = "image.jpg";
        string outputImage = "output.jpg";

        // Convert image to byte array
        byte[] imageBytes = File.ReadAllBytes(sourceImage);

        // Write byte array back to image
        using (MemoryStream ms = new MemoryStream(imageBytes))
        using (FileStream fs = new FileStream(outputImage, FileMode.Create, FileAccess.Write))
        {
            ms.WriteTo(fs);
        }

        Console.WriteLine("Image converted to byte array and saved successfully!");
    }
}
