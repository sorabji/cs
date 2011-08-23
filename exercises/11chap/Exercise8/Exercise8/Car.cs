using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise8
{
    public class Car
    {
        private String make,
                       model,
                       color,
                       pictureLocation;

        public String Make
        {
            get { return make; }
            set { make = value; }
        }

        public String Model
        {
            get { return model; }
            set { model = value; }
        }

        public String Color
        {
            get { return color; }
            set { color = value; }
        }

        public String PictureLocation
        {
            get { return pictureLocation; }
            set { pictureLocation = value; }
        }
                       
    }
}
