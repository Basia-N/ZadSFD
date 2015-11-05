using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFDZadanie
{
    public class Produkt
    {
        public int ID { get; set; }
        public string Nazwa { get; set; }
        public bool Dostepny { get; set; }
        public decimal Cena { get; set; }


        public static Produkt[] Pobierz()
        {
            return new Produkt[] {
                new Produkt{ ID = 1, Nazwa="Glutamina", Dostepny=true, Cena=20.5m},
                new Produkt{ ID = 2, Nazwa="Amino Plus", Dostepny=false, Cena=11.25m},
                new Produkt{ ID = 3, Nazwa="Energy Musli", Dostepny=true, Cena=5.5m},
                new Produkt{ ID = 4, Nazwa="Energy Drink", Dostepny=true, Cena=3.75m},
                new Produkt{ ID = 5, Nazwa="Energy Baton", Dostepny=false, Cena=0.90m},
                new Produkt{ ID = 6, Nazwa="Power Drink", Dostepny=false, Cena=1.90m}
            };
        }
    }
}
