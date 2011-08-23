using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise8
{
    public class Car
    {
        // maybe add a google query string?
        private String query,
                       year,
                       make,
                       model,
                       color;

        private System.Drawing.Image image;

        public Car(string year, string make, string model, string color, System.Drawing.Image image)
        {
            // TODO: Complete member initialization
            this.year = year;
            this.make = make;
            this.model = model;
            this.color = color;
            this.image = image;

            String[] makes = this.make.Split();
            String[] models = this.model.Split();
            this.query = "";
        }

        public String Query
        {
            get { return query; }
            set { query = value; }
        }

        public String Year
        {
            get { return year; }
            set { year = value; }
        }

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

        public System.Drawing.Image Image
        {
            get { return image; }
            set { image = value; }
        }
    }
}
