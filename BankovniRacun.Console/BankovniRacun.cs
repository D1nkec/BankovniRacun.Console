using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class BankovniRacun
    {
       
        public decimal StanjeRacuna { get; private set; }
        public List<string> Transakcije { get; set; }

        public BankovniRacun(decimal pocetnoStanje)
        {
            StanjeRacuna = pocetnoStanje;
            Transakcije = new List<string>() { $"Početno stanje: {pocetnoStanje}" };
        }


        public  void Uplata(decimal iznos)
        {
          StanjeRacuna += iznos;
          Transakcije.Add($"Uplata: {iznos}");
        }



        public void IspisiTransakcije()
        {
            foreach (var t in Transakcije)
            {
                Console.WriteLine(t);
            }
        }
    }

