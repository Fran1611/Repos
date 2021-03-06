using System;
using System.Collections.Generic;
using System.Text;
using CompAndDel;
using System.Drawing;
using System.Diagnostics;

namespace CompAndDel.Filters
{
    public class FilterSaveImage : IFilter
    {
        
        public IPicture Filter(IPicture image)
        {
            IPicture savePicture = image.Clone();
            PictureProvider p = new PictureProvider();
            p.SavePicture(savePicture, "NewImage.jpg");
            return savePicture;
        }
        
    }
}