using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PA2_BE;

namespace PA2_ADO
{
    internal class PacienteADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;


        public DataTable ListarPacientes()
        {

            try
            {
                DataSet dts = new DataSet();
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_Listar_Pacientes";
                cmd.Parameters.Clear();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Pacientes");
                return dts.Tables["Pacientes"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public PacientesBE ConsultarPaciente(String id_paciente)
        {

            try
            {
                PacientesBE objPacientesBE = new PacientesBE();
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarProducto"; // MODIFICAR SEGUN DB

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@vcod", id_paciente); // consultar el nombre de la variable en la DB
                cnx.Open();
                dtr = cmd.ExecuteReader();
                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objPacientesBE.id_pac = Convert.ToInt32(dtr["id_pac"]);
                    objPacientesBE.nom_pac = dtr["nom_pac"].ToString();
                    objPacientesBE.dni_pac = dtr["dni_pac"].ToString();
                    objPacientesBE.ape_paci = dtr["ape_paci"].ToString();
                    objPacientesBE.fecha_nac_pac = Convert.ToDateTime(dtr["fecha_nac_pac"]);
                    objPacientesBE.sexo_pac = Convert.ToBoolean(dtr["sexo_pac"]);
                    objPacientesBE.direccion_pac = dtr["direccion_pac"].ToString();
                    objPacientesBE.telefono_pac = dtr["telefono_pac"].ToString();
                    objPacientesBE.tip_sangre_pac = dtr["tip_sangre_pac"].ToString();
                    objPacientesBE.talla_pac = dtr["talla_pac"].ToString();
                    objPacientesBE.peso_pac = float.Parse(dtr["peso_pac"].ToString());
                    objPacientesBE.est_civ_pac = dtr["est_civ_pac"].ToString();
                    objPacientesBE.comentarios_pac = dtr["comentarios_pac"].ToString();
                    objPacientesBE.correo_pac = dtr["correo_pac"].ToString();
                    objPacientesBE.foto_pac = dtr["foto_pac"].ToString();
                    objPacientesBE.fecha_af_seg_pac = Convert.ToDateTime(dtr["fecha_at_seg_pac"]);
                    objPacientesBE.id_seguro = Convert.ToInt32(dtr["id_seguro"]);
                    objPacientesBE.cobertura_pac = dtr["cobertura_pac"].ToString();
                    objPacientesBE.nro_poliza_pac = dtr["nro_poliza_pac"].ToString();
                    objPacientesBE.id_ubigeo = dtr["id_ubigeo"].ToString();
                    objPacientesBE.usu_reg_pac = dtr["usu_reg_pac"].ToString();
                    objPacientesBE.fecha_registro_pac = Convert.ToDateTime(dtr["fecha_registro_pac"]);
                    objPacientesBE.usu_ult_mod_pac = dtr["usu_ult_mod_pac"].ToString();
                    objPacientesBE.fecha_ult_mod_pac = Convert.ToDateTime(dtr["fecha_ult_mod_pac"]);
                    objPacientesBE.estado_pac = Convert.ToBoolean(dtr["estado_pac"]);

                }
                dtr.Close();
                return objPacientesBE;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

            }

        }
        public Boolean InsertarProducto(PacientesBE objPacienteBE)
        {

            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_Insertar_Tb_Pacientes";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nom_Pac", objPacienteBE.nom_pac);
                cmd.Parameters.AddWithValue("@dni_pac", objPacienteBE.dni_pac);
                cmd.Parameters.AddWithValue("@ape_Paci", objPacienteBE.ape_paci);
                cmd.Parameters.AddWithValue("@fecha_nac_Pac", objPacienteBE.fecha_nac_pac);
                cmd.Parameters.AddWithValue("@sexo_pac", objPacienteBE.sexo_pac);
                cmd.Parameters.AddWithValue("@direccion_pac", objPacienteBE.direccion_pac);
                cmd.Parameters.AddWithValue("@telefono_pac", objPacienteBE.telefono_pac);
                cmd.Parameters.AddWithValue("@tip_sangre_pac", objPacienteBE.tip_sangre_pac);
                cmd.Parameters.AddWithValue("@talla_pac", objPacienteBE.talla_pac);
                cmd.Parameters.AddWithValue("@peso_pac", objPacienteBE.peso_pac);
                cmd.Parameters.AddWithValue("@foto_pac", objPacienteBE.foto_pac);
                cmd.Parameters.AddWithValue("@est_civ_pac", objPacienteBE.est_civ_pac);
                cmd.Parameters.AddWithValue("@comentarios_pac", objPacienteBE.comentarios_pac);
                cmd.Parameters.AddWithValue("@correo_pac", objPacienteBE.correo_pac);
                cmd.Parameters.AddWithValue("@id_seguro", objPacienteBE.id_seguro);
                cmd.Parameters.AddWithValue("@fecha_af_seg_pac", objPacienteBE.fecha_af_seg_pac);
                cmd.Parameters.AddWithValue("@cobertura_pac", objPacienteBE.cobertura_pac);
                cmd.Parameters.AddWithValue("@nro_poliza_pac", objPacienteBE.nro_poliza_pac);
                cmd.Parameters.AddWithValue("@id_ubigeo", objPacienteBE.id_ubigeo);

                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
                return false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

            }
        }
        public Boolean ActualizarProducto(PacientesBE objPacienteBE)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_Actualizar_Tb_Pacientes";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@id_Pac", objPacienteBE.id_pac);
                cmd.Parameters.AddWithValue("@nom_Pac", objPacienteBE.nom_pac);
                cmd.Parameters.AddWithValue("@dni_pac", objPacienteBE.dni_pac);
                cmd.Parameters.AddWithValue("@ape_Paci", objPacienteBE.ape_paci);
                cmd.Parameters.AddWithValue("@fecha_nac_Pac", objPacienteBE.fecha_nac_pac);
                cmd.Parameters.AddWithValue("@sexo_pac", objPacienteBE.sexo_pac);
                cmd.Parameters.AddWithValue("@direccion_pac", objPacienteBE.direccion_pac);
                cmd.Parameters.AddWithValue("@telefono_pac", objPacienteBE.telefono_pac);
                cmd.Parameters.AddWithValue("@tip_sangre_pac", objPacienteBE.tip_sangre_pac);
                cmd.Parameters.AddWithValue("@talla_pac", objPacienteBE.talla_pac);
                cmd.Parameters.AddWithValue("@peso_pac", objPacienteBE.peso_pac);
                cmd.Parameters.AddWithValue("@foto_pac", objPacienteBE.foto_pac);
                cmd.Parameters.AddWithValue("@est_civ_pac", objPacienteBE.est_civ_pac);
                cmd.Parameters.AddWithValue("@comentarios_pac", objPacienteBE.comentarios_pac);
                cmd.Parameters.AddWithValue("@correo_pac", objPacienteBE.correo_pac);
                cmd.Parameters.AddWithValue("@id_seguro", objPacienteBE.id_seguro);
                cmd.Parameters.AddWithValue("@fecha_af_seg_pac", objPacienteBE.fecha_af_seg_pac);
                cmd.Parameters.AddWithValue("@cobertura_pac", objPacienteBE.cobertura_pac);
                cmd.Parameters.AddWithValue("@nro_poliza_pac", objPacienteBE.nro_poliza_pac);
                cmd.Parameters.AddWithValue("@id_ubigeo", objPacienteBE.id_ubigeo);

                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
                return false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

            }


        }

        public Boolean EliminarProducto(String id_Pac)
        {


            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_Eliminar_Tb_Pacientes";
                //Agregamos parametros
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_Pac", id_Pac);
                cnx.Open();
                cmd.ExecuteNonQuery();

                return true;

            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
                return false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

            }

        }
    }
}
