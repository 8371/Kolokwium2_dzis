using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium2_dzis
{
    public class Pociag : Transport
    {
        private int dlugoscTrasy;

        public Pociag(int iloscMiejsc, int dlugoscTrasy)
        {
            this.iloscMiejsc = iloscMiejsc;
            this.dlugoscTrasy = dlugoscTrasy;
            this.obliczCene();
        }

        public override string ToString() => $"Pociąg: ilość miejsc: {iloscMiejsc}, długość trasy: {dlugoscTrasy}, cena biletu: {cenaBiletu}";

        public override void obliczCene()
        {
            if (dlugoscTrasy > 100)
                cenaBiletu = dlugoscTrasy * 1.45;
            else
                base.obliczCene();
        }


    }
}
