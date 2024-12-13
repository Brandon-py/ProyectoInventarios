using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Capa_Entidad;



namespace Capa_Datos
{
    public class ClaseDatos
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);

        public DataTable D_listar_productos ()
        {
            SqlCommand cmd = new SqlCommand("sp_listar_productos",cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable D_buscar_productos(ClaseModelo obje) 
        {
            SqlCommand cmd = new SqlCommand("sp_buscar_productos", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Descripcion", obje.Descripcion);
            SqlDataAdapter da = new SqlDataAdapter (cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;


        }

        public String D_mantenimiento_inventario(ClaseModelo obje)
        {
            String Accion = "";
            SqlCommand cmd = new SqlCommand("sp_mantenimiento_inventario", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Codigo", obje.Codigo);
            cmd.Parameters.AddWithValue("@Descripcion", obje.Descripcion);
            cmd.Parameters.AddWithValue("@Cantidad", obje.Cantidad);
            cmd.Parameters.AddWithValue("@Ubicacion", obje.Ubicacion);
            cmd.Parameters.AddWithValue("@Accion", obje.Accion);
            cmd.Parameters.Add("@Accion", SqlDbType.VarChar, 50).Value = obje.Accion;
            cmd.Parameters["@Accion"].Direction = ParameterDirection.InputOutput;
            if (cn.State == ConnectionState.Open) cn.Close();
            cn.Open();
            cmd.ExecuteNonQuery();
            Accion = cmd.Parameters["@Accion"].Value.ToString();
            cn.Close();
            return Accion;





        }


    }
}
