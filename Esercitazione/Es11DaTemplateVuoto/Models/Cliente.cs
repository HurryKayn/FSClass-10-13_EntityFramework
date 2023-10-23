using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Es11DaTemplateVuoto.Models
{
    public enum eZona {None, NordEst, NordOvest,Centro,Sud, Isole }
    public class Cliente
    {
        [DisplayName("ID")]
        public int? ClienteId { get; set; }
        [Required(ErrorMessage = "Il campo Nome è obbligatorio.")]
        [MaxLength(50)]
        [MinLength(3, ErrorMessage = "Inserire almeno 3 caratteri")]
        [DisplayName("Ragione Sociale")]
        public string Nome { get; set; }
        public string? Cognome { get; set; }

        [DisplayFormat(DataFormatString = "dd/MM/yyyy")]
        [DataType(DataType.Date)]
        public DateTime? Data { get; set; }

        [DataType(DataType.Time)]
        public DateTime? Ora { get; set; }

        public bool Attivo { get; set; }

        public int? Numero { get; set; } 

        public eZona Zona { get; set; }
        
    }
}
