using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex32
{
    public abstract class Organization
    {
        public string name { get; }

        private string adress;

        public string Address
        {
            get { return adress; }
            set { adress = value; }
        }

        public Organization(string name)
        {
            this.name = name;
        }
    }
}
