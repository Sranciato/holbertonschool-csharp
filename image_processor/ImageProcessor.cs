﻿using System;
using System.Collections.Generic;
using System.Drawing;

///<summary>ImpageProcessor class</summary>
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
            string concatFile = file.Substring(7, file.Length - 11) + "_inverse." + file.Substring(file.Length - 3, 3);
            image1.Save(concatFile);
            
        }
    }
}