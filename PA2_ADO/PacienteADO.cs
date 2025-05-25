using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public PacientesBE ConsultarProducto(String strCodigo)
        {

            try
            {
                ProductoBE objProductoBE = new ProductoBE();
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarProducto";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@vcod", strCodigo);
                cnx.Open();
                dtr = cmd.ExecuteReader();
                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objProductoBE.Cod_pro = dtr["Cod_pro"].ToString();
                    objProductoBE.Des_pro = dtr["Des_pro"].ToString();
                    objProductoBE.Pre_pro = Convert.ToSingle(dtr["Pre_pro"]);
                    objProductoBE.Stk_act = Convert.ToInt16(dtr["Stk_act"]);
                    objProductoBE.Stk_min = Convert.ToInt16(dtr["Stk_min"]);
                    objProductoBE.Id_UM = Convert.ToInt16(dtr["id_UM"]);
                    objProductoBE.Id_Cat = Convert.ToInt16(dtr["id_Cat"]);
                    objProductoBE.Importado = Convert.ToInt16(dtr["Importado"]);
                    objProductoBE.Est_pro = Convert.ToInt16(dtr["Est_pro"]);
                }
                dtr.Close();
                return objProductoBE;
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
        public Boolean InsertarProducto(ProductoBE objProductoBE)
        {

            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertarProducto";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@vdes", objProductoBE.Des_pro);
                cmd.Parameters.AddWithValue("@vpre", objProductoBE.Pre_pro);
                cmd.Parameters.AddWithValue("@vstka", objProductoBE.Stk_act);
                cmd.Parameters.AddWithValue("@vstkm", objProductoBE.Stk_min);
                cmd.Parameters.AddWithValue("@vld_UM", objProductoBE.Id_UM);
                cmd.Parameters.AddWithValue("@vld_Cat", objProductoBE.Id_Cat);
                cmd.Parameters.AddWithValue("@vimp", objProductoBE.Importado);
                cmd.Parameters.AddWithValue("@vUsu_Registro", objProductoBE.Usu_Registro);
                cmd.Parameters.AddWithValue("@vest_pro", objProductoBE.Est_pro);
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
        public Boolean ActualizarProducto(PacientesBE objPacientesBE)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ActualizarProducto";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@vcod", objPacientesBE.Cod_pro);
                cmd.Parameters.AddWithValue("@vdes", objPacientesBE.Des_pro);
                cmd.Parameters.AddWithValue("@vpre", objPacientesBE.Pre_pro);
                cmd.Parameters.AddWithValue("@vstka", objPacientesBE.Stk_act);
                cmd.Parameters.AddWithValue("@vstkm", objPacientesBE.Stk_min);
                cmd.Parameters.AddWithValue("@vld_UM", objPacientesBE.Id_UM);
                cmd.Parameters.AddWithValue("@vld_Cat", objPacientesBE.Id_Cat);
                cmd.Parameters.AddWithValue("@vimp", objPacientesBE.Importado);
                cmd.Parameters.AddWithValue("@vUsu_Ult_Mod", objPacientesBE.Usu_Ult_Mod);
                cmd.Parameters.AddWithValue("@vest_pro", objPacientesBE.Est_pro);
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

        public Boolean EliminarProducto(String strCodigo)
        {


            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_EliminarProducto";
                //Agregamos parametros
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@vood", strCodigo);
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
