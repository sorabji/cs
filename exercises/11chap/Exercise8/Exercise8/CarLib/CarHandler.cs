using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Exercise8.CarLib
{
    class CarHandler
    {
        private const String imagePathPrefix = @"../../media\";
        private const String carPathPrefix = @"../../data\";
        private const String carFile = "cars.txt";
        private static char[] delim = { '|' };

        public static List<Car> GetCarList()
        {
            List<Car> cars = new List<Car>();
            string[] tokens;
            string year,
                   make,
                   model,
                   color,
                   imageName;

            System.Drawing.Image image;
            FileStream carStream = new FileStream(carPathPrefix + carFile, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(carStream);
            String line = "";
            while ((line = reader.ReadLine()) != null)
            {
                tokens = line.Split(delim);
                year = tokens[0];
                make = tokens[1];
                model = tokens[2];
                color = tokens[3];
                image = System.Drawing.Image.FromFile(imagePathPrefix+tokens[4]);
                cars.Add(new Car(year, make, model, color, image));
            }
            reader.Close();
            carStream.Close();
            return cars;
        }
    }
}
