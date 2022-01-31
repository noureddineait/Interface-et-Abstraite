using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Interfaces
{
    internal interface ITransport
    {

        int Prix(Marchandise march);
       
    }

    class TransportRoutier : ITransport
    {
        int pu = 2;
        public int Prix(Marchandise march)
        {
            return this.pu * march.Volume;
        }
    }

    abstract class TransportAerien : ITransport
    {
        protected int pu = 10;
        public abstract int Prix(Marchandise march);
    }
    class TransportAerienNormal : TransportAerien
    {
        public override int Prix(Marchandise march)
        {
            return march.Poids*base.pu;
        }

    }
    class TransportAerienUrgent : TransportAerien
    {
        public override int Prix(Marchandise march)
        {
            return march.Poids * base.pu*2;
        }

    }




}
