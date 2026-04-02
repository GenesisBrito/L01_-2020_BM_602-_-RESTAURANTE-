using System.ComponentModel.DataAnnotations;

namespace L01__2020_BM_602___RESTAURANTE_.Models
{
    public class Equipo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public required string Nombre { get; set; }

        [Required(ErrorMessage = "La descripción es obligatoria")]
        public required string Descripcion { get; set; }

        // Opcional: puede ser null
        public int? TipoEquipoId { get; set; }
        public int? MarcaId { get; set; }

        [Required(ErrorMessage = "El modelo es obligatorio")]
        public required string Modelo { get; set; }

        public int? AnioCompra { get; set; }

        [Required(ErrorMessage = "El costo es obligatorio")]
        [Range(0, double.MaxValue, ErrorMessage = "El costo debe ser mayor o igual a 0")]
        public decimal Costo { get; set; }

        public int? VidaUtil { get; set; }
        public int? EstadoEquipoId { get; set; }

        [Required(ErrorMessage = "El estado es obligatorio")]
        public required string Estado { get; set; }
    }
}