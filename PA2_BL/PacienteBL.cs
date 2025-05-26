using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PA2_ADO;
using PA2_BE;

namespace PA2_BL
{
    public class PacienteBL
    {
        PacienteADO objPacienteADO = new PacienteADO();
        public DataTable ListarPaciente()
        {
            return objPacienteADO.ListarPacientes();
        }
        public PacientesBE ConsultarProducto(String strCodigo)
        {
            return objPacienteADO.ConsultarPaciente(strCodigo);
        }

        public Boolean InsertarPaciente(PacientesBE objPacienteBE)
        {
            return objPacienteADO.InsertarPaciente(objPacienteBE);
        }
        public Boolean ActualizarProducto(PacientesBE objPacienteBE)
        {
            return objPacienteADO.ActualizarPaciente(objPacienteBE);
        }
        public Boolean EliminarProducto(string id_Pac)
        {
            return objPacienteADO.EliminarPaciente(id_Pac);
        }
    }
}
