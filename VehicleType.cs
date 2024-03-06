using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Group_6_DIS_Spring_2024
{
    internal class VehicleType
    {
        public string model;
        public string type;


        // Getter method for Model
        public string GetModel()
        {
            return model;
        }

        // Getter method for Type
        public string getType()
        {
            return type;
        }

        public void setModel(string model)
        {
            model = this.model;
        }

        public void setType(string type)
        {
            type = this.type;
        }

        // Method to display vehicle information
        public void DisplayInfo()
        {
            Console.WriteLine($"Vehicle Model: {model}");
            Console.WriteLine($"Vehicle Type: {type}");
        }
    }
}
