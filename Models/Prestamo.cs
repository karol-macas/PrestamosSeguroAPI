namespace PrestamosSegurosAPI.Models
{
    public class Prestamo
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public decimal Monto { get; set; }
        public int PlazoMeses { get; set; }
        public double TasaInteres { get; set; }
        public DateTime FechaSolicitud { get; set; }

        public string Estado { get; set; }

        public Usuario Usuario { get; set; }


    }
}
