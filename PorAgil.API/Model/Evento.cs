namespace PorAgil.API.Model
{
    public class Evento
    {
        
        public int EventoID { get; set; }
        public string Local { get; set; }
        public string DataEvento { get; set; }
        public string Tema { get; set; }
        public int QtdePessoas { get; set; }
        public string Lote { get; set; }
        public string ImagemUrl { get; set; }
        public string Promoter {get;set;}

    }
}