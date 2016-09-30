using System;
using System.Collections.Generic;
using System.Text;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using System.Drawing;


namespace ImageProcessEmguTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Mat img = new Mat(200, 400, DepthType.Cv8U, 3))
            {
                img.SetTo(new Bgr(255, 230, 0).MCvScalar);

                CvInvoke.PutText(
                    img,
                    "Hello World",
                    new System.Drawing.Point(10,80),
                    FontFace.HersheyComplex,
                    1.0,
                    new Bgr(0,243,0).MCvScalar);

                ImageViewer.Show(img, "Test Window");
            }

        }
    }
}
