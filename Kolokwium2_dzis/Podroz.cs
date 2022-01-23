using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium2_dzis
{
    interface IZarzadzaj
    {
        void DodajAutobus(int iloscMiejsc);
        void DodajPociag(int iloscMiejsc, int dlugoscTrasy);
        void UsunOstatni();
        void Wyczysc();
    }
    interface IData
    {
        void UstawDate(DateTime data);
        bool SprawdzDate();
    }
    public class Podroz : IZarzadzaj, IData
    {
        private DateTime dataPodrozy = DateTime.Now;
        private List<Transport> planPodrozy = new List<Transport>();

        private double koszt = 0;


        public void Wyswietl()
        {
            planPodrozy.ForEach(Console.WriteLine);
        }
        public int get_planpodrozyLEN()
        {
            return planPodrozy.Count();
        }

        public void DodajAutobus(int iloscMiejsc)
        {
            Autobus autobus = new Autobus(iloscMiejsc);
            planPodrozy.Add(autobus);
            koszt += autobus.getCenaBiletu();
        }

        public void DodajPociag(int iloscmiejsc, int dlugoscTrasy)
        {
            Pociag pociag = new Pociag(iloscmiejsc, dlugoscTrasy);
            planPodrozy.Add(pociag);
            koszt += pociag.getCenaBiletu();
        }
        public void UsunOstatni() => planPodrozy.RemoveAt(planPodrozy.Count - 1);

        public void Wyczysc()
        {
            planPodrozy.Clear();
        }

        public void UstawDate(DateTime data)
        {
            dataPodrozy = data;
        }

        public bool SprawdzDate()
        {
            if (dataPodrozy > DateTime.Now)
                return true;
            else
                return false;
        }
        public DateTime ZwrocDate()
        {
            return dataPodrozy;
        }

        public override string ToString()
        {
            String info = "";
            foreach (Transport x in planPodrozy)
                info += x + "\n";
            info += $"Koszt: {koszt}";
            return info;
        }
    }
}
