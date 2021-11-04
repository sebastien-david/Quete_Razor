using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quete_Razor.Models
{
    public class Expenditure
    {
        public string Nom { get; set; }
        public DateTime Date { get; set; }
        public double Prix { get; set; }

        public Expenditure(string nom, DateTime date, double prix)
        {
            Nom = nom;
            Date = date;
            Prix = prix;
        }
    }
}
