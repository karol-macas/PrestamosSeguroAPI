namespace PrestamosSegurosAPI.Models
{
    public class Pago
    {
        public int Id { get; set; }
        public int PrestamoId { get; set; }
        public decimal MontoPagado { get; set; }

        public DateTime FechaPago { get; set; }

        public Prestamo Prestamo { get; set; }

    }
}
