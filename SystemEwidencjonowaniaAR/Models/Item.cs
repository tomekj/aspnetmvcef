using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SystemEwidencjonowaniaAR.Models
{
    public class Item
    {
        [Key]
        public int ID { get; set; }
        public string KategoriaZasobu { get; set; }
        [MaxLength(100) MinLength(5)]
        public string Nazwa { get; set; }
        [MaxLength(30)]
        public string Producent { get; set; }
        [MaxLength(50)]
        public string Model { get; set; }
        [MaxLength(250)]
        public string Opis { get; set; }
        [Index(IsUnique = true)]
        [MaxLength(50)]
        public string NrSeryjny { get; set; }
        [Index(IsUnique = true) MaxLength(10)]
        public string NrInw { get; set; }
        [DefaultValue("nieznany")]
        public string Status { get; set; }
        public DateTime? DataWrpowadzenia { get; set; }
    }
}