using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium2_dzis
{
    class Autobus : Transport
    {
        public Autobus(int iloscsm)
        {
            iloscMiejsc = iloscsm;
            base.obliczCene();
        }

        public override string ToString() => $"Autobus: ilość miejsc: {iloscMiejsc}, cena biletu: {cenaBiletu}";
    }
}
