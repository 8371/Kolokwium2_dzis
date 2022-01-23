using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium2_dzis
{
    public abstract class Transport
    {
        protected int iloscMiejsc;
        protected double cenaBiletu;

        protected Transport()
        {
        }
        public virtual void obliczCene()
        {
            cenaBiletu = 110;
        }
        public double getCenaBiletu()
        {
            return cenaBiletu;
        }
    }
}
