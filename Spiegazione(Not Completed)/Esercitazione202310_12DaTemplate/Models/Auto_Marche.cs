using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;

namespace Esercitazione202310_12DaTemplate.Models
{
    public class Auto_Marche
    {
        public Automobile? Auto { get; set; }
        //** NO NO NO public List<string> ElencoMarche { get; set; }  NO NO NO 
        public List<SelectListItem> ElencoMarche { get; set; }

        public Auto_Marche()
        {

            ElencoMarche = new List<SelectListItem>();
            string s; int i =0;
            
            i++;s = "Alfa";ElencoMarche.Add(new SelectListItem { Value=i.ToString(), Text=s });
            i++; s = "Audi"; ElencoMarche.Add(new SelectListItem { Value = i.ToString(), Text = s });
            i++; s = "BMW"; ElencoMarche.Add(new SelectListItem { Value = i.ToString(), Text = s });
            i++; s = "Jaguar"; ElencoMarche.Add(new SelectListItem { Value = i.ToString(), Text = s });
            i++; s = "Volvo"; ElencoMarche.Add(new SelectListItem { Value = i.ToString(), Text = s });
        }
    }
}
