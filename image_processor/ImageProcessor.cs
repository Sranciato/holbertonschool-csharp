using System;
using System.Collections.Generic;
using System.Drawing;

///<summary>ImageProcessor class</summary>
class ImageProcessor
{
    ///<summary>Method for inversing pixel color for images</summary>
    public static void Inverse(string[] filenames)
    {
        foreach (string file in filenames)
        {
            Bitmap image1 = new Bitmap(file);

            int x, y;

            for(x = 0; x < image1.Width; x++)
            {
                for(y = 0; y < image1.Height; y++)
                {
                    Color pixelColor = image1.GetPixel(x, y);
                    Color newColor = Color.FromArgb(255, (255 - pixelColor.R), (255 - pixelColor.G), (255 - pixelColor.B));
                    image1.SetPixel(x, y, newColor);
                }
            }
            string name = file.Split("/")[1];
            string[] newName = name.Split(".");
            string concatFile = newName[0] + "_inverse." + newName[1];
            image1.Save(concatFile);
            
        }
    }

    ///<summary>Method for converting images to grayscale</summary>
    public static void Grayscale(string[] filenames)
    {
        foreach (string file in filenames)
        {
            Bitmap image1 = new Bitmap(file);

            int x, y;

            for(x = 0; x < image1.Width; x++)
            {
                for(y = 0; y < image1.Height; y++)
                {
                    Color pixelColor = image1.GetPixel(x, y);
                    int grayScale = (int)((pixelColor.R * 0.3) + (pixelColor.G * 0.59) + (pixelColor.B * 0.11));
                    Color newColor = Color.FromArgb(pixelColor.A, grayScale, grayScale, grayScale);
                    image1.SetPixel(x, y, newColor);
                }
            }
            string name = file.Split("/")[1];
            string[] newName = name.Split(".");
            string concatFile = newName[0] + "_grayscale." + newName[1];
            image1.Save(concatFile);
            
        }
    }

    ///<summary>Method for converting images to grayscale</summary>
    public static void BlackWhite(string[] filenames, double threshold)
    {
        foreach (string file in filenames)
        {
            Bitmap image1 = new Bitmap(file);
            Color newColor;

            int x, y;

            for(x = 0; x < image1.Width; x++)
            {
                for(y = 0; y < image1.Height; y++)
                {
                    Color pixelColor = image1.GetPixel(x, y);
                    if (GetBrightness(pixelColor) >= threshold)
                    {
                        newColor = Color.FromArgb(pixelColor.A, 255, 255, 255);
                    }
                    else
                    {
                        newColor = Color.FromArgb(pixelColor.A, 0, 0, 0);
                    }
                    image1.SetPixel(x, y, newColor);
                }
            }
            string name = file.Split("/")[1];
            string[] newName = name.Split(".");
            string concatFile = newName[0] + "_bw." + newName[1];
            image1.Save(concatFile);
            
        }
    }
    public static double GetBrightness(Color color)
    {
        return (0.2126*color.R + 0.7152*color.G + 0.0722*color.B);
    }

    ///<summary>Method for converting images to grayscale</summary>
    public static void Thumbnail(string[] filenames, int height)
    {
        foreach (string file in filenames)
        {
            Image image = Image.FromFile(file);
            int aspect = image.Height / height;
            Image thumb = image.GetThumbnailImage(image.Width / aspect , height, ()=>false, IntPtr.Zero);

            string name = file.Split("/")[1];
            string[] newName = name.Split(".");
            string concatFile = newName[0] + "_th." + newName[1];
            thumb.Save(concatFile);
        }
    }
}