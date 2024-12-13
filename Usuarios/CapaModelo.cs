using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    [Table(name: "Clientes")]
    public class Cliente
    {

        [Column(name: "nombres_cliente")]
        [Required]
        public string Nombres { get; set; }
        [Column(name: "apellidos_cliente")]
        [Required]
        public string Apellidos { get; set; }
        [Column(name: "documento_cliente")]
        public string Documento { get; set; }
        [Column(name: "direccion_cliente")]
        [Required]
        public string Direccion { get; set; }
    }
}