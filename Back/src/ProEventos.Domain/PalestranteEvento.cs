namespace ProEventos.Domain
{
    public class PalestranteEvento
    {
        public int PalestranteId { get; set; }
        public Palestrante Palestrante { get; set; }
        public int EventoID { get; set; }
        public Evento Eventos { get; set; }
    }
}