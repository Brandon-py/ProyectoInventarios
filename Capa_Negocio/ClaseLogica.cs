using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Entidad;

namespace Capa_Negocio
{
    public class ClaseLogica
    {
        ClaseDatos objd= new ClaseDatos();

        public DataTable N_listar_productos()
        {
            return objd.D_listar_productos();
        }

        public DataTable N_buscar_productos(ClaseModelo obje)
        {
            return objd.D_buscar_productos(obje);

        }

        public String N_mantenimiento_inventario(ClaseModelo obje)
        {
            return objd.D_mantenimiento_inventario(obje);
        }





    }
}
