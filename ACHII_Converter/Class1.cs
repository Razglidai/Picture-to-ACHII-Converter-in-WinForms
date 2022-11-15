using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ACHII_Converter
{
    public class BitmapConvert
    {
        readonly public int hPicture;
        public int wPicture;
        const int wSimbol = 11;
        const int hSimbol = 24;
        const float aspect = 11f / 24f;
        Bitmap bitmap;
        string gradient;
        static public string FileName = "Pinture";
        static readonly public string file_extension = ".txt";
        int file_counter = 0;
        public static bool IsNegative = false;
        public string path;
        public string gradiend;
       
        public BitmapConvert(Bitmap bitmap ,string gradiend = "@$8W9H4l(r/:.", int wPicture = 300)
        {
            this.bitmap = bitmap;
            this.wPicture = wPicture;  
            path = FileName + file_counter + file_extension;
            hPicture = (int)(bitmap.Height * wPicture / bitmap.Width * aspect);
            this.gradiend = gradiend;   

        }

        private void ResizeBitmap()
        {
           bitmap = new Bitmap(bitmap, new Size(wPicture, hPicture));
        }



        public char[][] bitmapConvert()
        {



            
            ResizeBitmap();
            bitmap.ToGrayscale();


            if (IsNegative == true)
            {
                gradiend= new string(gradiend.Reverse().ToArray());
            }
            char[][] result = new char[bitmap.Height][];
            for (int i = 0; i < bitmap.Height; i++)
            {
                result[i] = new char[bitmap.Width];
                for (int j = 0; j < bitmap.Width; j++)
                {
                    float PixelColor = bitmap.GetPixel(j, i).B;
                    float MaxColor = byte.MaxValue;
                    float GradientSize = gradiend.Length - 1;
                    float p = (int)(PixelColor / MaxColor * GradientSize);
                    result[i][j] = gradiend[(int)(PixelColor / MaxColor * GradientSize)];
                }
            }

            return result;
        }
        
    }
    public static class Ext
    {

        public static void ToGrayscale(this Bitmap bitmap)
        {
            for (int i = 0; i < bitmap.Height; i++)
            {
                for (int j = 0; j < bitmap.Width; j++)
                {
                    var pixel = bitmap.GetPixel(j, i);
                    int avg = (int)((pixel.R + pixel.G + pixel.B) / 3);
                    bitmap.SetPixel(j, i, Color.FromArgb(pixel.A, avg, avg, avg));

                }
            }
        }
    }
}
