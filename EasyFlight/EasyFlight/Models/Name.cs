using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyFlight.Models
{
    public class GeneralName
    {
        public string Name { get; private set; }

        private GeneralName(string name)
        {
            if (!name.StartsWith('A'))
                throw new ArgumentException();
            Name = name;
        }

        private GeneralName(string name, int n)
        {
            if (!name.StartsWith('B'))
                throw new ArgumentException();
            Name = name;
        }

        private GeneralName()
        {

        }
        public static GeneralName PersonalName(string n) => new GeneralName(n);

        public static GeneralName AirlineName(string n) => new GeneralName(n,1);

        public static GeneralName NoName() => new GeneralName();

        

    }
}
