namespace Esercitazione202310_12DaTemplate.Models
{
    public enum eColore { none,rosso, verde, giallo, grigio }


    public class Automobile
    {
        public int? AutomobileId { get; set; }
        public string Nome { get; set; }
        //sparisce --> public string? Marca {  get; set; }
        public int MarcaId {  get; set; }
        public eColore? Colore{ get; set; }
        public int? Posti{ get; set;}
        public decimal? Peso{ get; set;}
        public DateTime? DataImmatricolazione { get; set; }

    }
}
