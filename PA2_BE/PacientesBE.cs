using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA2_BE
{
    public class PacientesBE
    {
        public int id_pac { get; set; }
        public string nom_pac { get; set; }
        public string dni_pac { get; set; }
        public string ape_paci { get; set; }
        public DateTime fecha_nac_pac { get; set; }
        public bool sexo_pac { get; set; }
        public string direccion_pac { get; set; }
        public string telefono_pac { get; set; }
        public string tip_sangre_pac { get; set; }
        public string talla_pac { get; set; }
        public float peso_pac { get; set; }
        public string est_civ_pac { get; set; }
        public string comentarios_pac { get; set; }
        public string correo_pac { get; set; }
        public string foto_pac { get; set; }
        public DateTime fecha_af_seg_pac { get; set; }
        public int id_seguro { get; set; }
        public string cobertura_pac { get; set; }
        public string nro_poliza_pac { get; set; }
        public string id_ubigeo { get; set; }
        public string usu_reg_pac { get; set; }
        public DateTime fecha_registro_pac { get; set; }
        public string usu_ult_mod_pac { get; set; }
        public DateTime fecha_ult_mod_pac { get; set; }
        public bool estado_pac { get; set; }

    }
}
