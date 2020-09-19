using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ParcialRodolfoHeredia.Models
{
    public class LanguagesList
    {
        [Key]
        [Required]
        [Display(Name = "Ingrese abreviacion del lenguaje en ingles")]
        public string iso639_1 { get; set; }

        [Required]
        [Display(Name = "Ingrese abreviacion del lenguaje en español")]
        public string iso639_2 { get; set; }

        [Required]
        [Display(Name = "Ingrese lenguaje en ingles")]
        public string name { get; set; }

        [Required]
        [Display(Name = "Ingrese lenguaje en español")]
        public string nativeName { get; set; }


    }
    public class Country
    {
        [Key]
        [Required]
        [Display(Name = "Ingrese abreviacion minimo 3 letras")]
        [Range(3,3)]
        public string Alpha3code { get; set; }

        [Required]
        [Display(Name = "Ingrese Continente")]
        public string Region { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "Ingrese Pais")]
        public string Name { get; set; }

        [Required]
        [Range(1,10)]
        [Display(Name = "Ingrese Area")]
        public int Area { get; set; }

        [Required]
        [Range(2, 3)]
        [Display(Name = "Ingrese codigo numerico del pais")]
        public int CallingCode { get; set; }

        [Required]
        [Display(Name = "Lenguajes del pais")]
        public List<LanguagesList> Languages { get; set; }

        [Required]
        [Url]
        [Display(Name = "Bandera")]
        public string Flag { get; set; }
    }
}