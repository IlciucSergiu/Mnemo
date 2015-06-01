using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MemoTricks
{
    class ImageClass
    {
        public Image ReturnImage(int _image)
        {
             Image img = new Bitmap(250 , 160);
            #region
            switch (_image)
            {
                case 1:
                    {
                        img = Imagini1._1_img;
                        break;
                    }
                case 2:
                    {
                        img = Imagini1._2_img;
                        break;
                    }
                case 3:
                    {
                        img = Imagini1._3_img;
                        break;
                    }
                case 4:
                    {
                        img = Imagini1._4_img;
                        break;
                    }
                case 5:
                    {
                        img = Imagini1._5_img;
                        break;
                    }
                case 6:
                    {
                        img = Imagini1._6_img;
                        break;
                    }
                case 7:
                    {
                        img = Imagini1._7_img;
                        break;
                    }
                case 8:
                    {
                        img = Imagini1._8_img;
                        break;
                    }
                case 9:
                    {
                        img = Imagini1._9_img;
                        break;
                    }
                case 10:
                    {
                        img = Imagini1._10_img;
                        break;
                    }

            }
            #endregion
            return img;
        }
        public Bitmap CropImage(Bitmap sourceImage,int x, int y, int width, int height)
        {
            Rectangle cropRect = new Rectangle(x, y, width, height);
             sourceImage = Imagini2.loci_house;
            Bitmap returnImage = sourceImage.Clone(cropRect, sourceImage.PixelFormat);

            return returnImage;
        }
    }
}
