using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Net.NetworkInformation;

namespace L01__2020_BM_602___RESTAURANTE_.Properties
{
    [Route("api/[controller]")]
    [ApiController]
    public class restaurantes : ControllerBase
    {
        public class equipos
        {
            [Key]
            public int { get; set; }
            public string nombre { get; set; }
            public string descripcion { get; set; }
            public int? tipo_equipo_id { get; set; }
            public int? marca_id { get; set; }
            public string modelo { get; set; }
            public int? anio_compra { get; set; }
            public decimal costo { get; set; }
            public int? vida_util { get; set; }
            public int? estado_equipo_id { get; set; }
            public string estado { get; set; }
        }

    }
}
}
