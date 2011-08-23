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
            string query, 
                   year,
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
                query = tokens[0];
                year = tokens[1];
                make = tokens[2];
                model = tokens[3];
                color = tokens[4];
                image = System.Drawing.Image.FromFile(imagePathPrefix+tokens[5]);
                cars.Add(new Car(query, year, make, model, color, image));
            }
            reader.Close();
            carStream.Close();
            return cars;
        }
    }
}
