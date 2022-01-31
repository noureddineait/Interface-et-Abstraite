using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Interfaces
{
     class Marchandise
    {
        int volume;
        int poids;

        public Marchandise(int volume,int poids)
        {
            this.poids = poids;
            this.volume = volume;   
        }
        public int Volume{ 
            get{ return this.volume; }
            set { this.volume = value; }
        }
        
        public int Poids
        {
            get { return this.poids; }
            set { this.poids = value; }
        }
    }
}
