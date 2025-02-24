﻿using AForge.Imaging.Filters;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcess.filters
{
    class ProcessPlaca
    {
        public Bitmap process(Bitmap bmp)
        {
            Bitmap newImage = (Bitmap)bmp.Clone();
            newImage = Grayscale.CommonAlgorithms.Y.Apply(newImage);
            newImage = new AForge.Imaging.Filters.Threshold(50).Apply(newImage);
            Dilatation filter = new Dilatation();
            newImage = filter.Apply(newImage);
            newImage = filter.Apply(newImage);
            Erosion filter2 = new Erosion();
            newImage = filter2.Apply(newImage);
            newImage = filter2.Apply(newImage);
            newImage = filter2.Apply(newImage);
            return newImage;
        }
        }
}
