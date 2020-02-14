using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neo
{
    class Utilidad
    {
        //formularios mantenimientos
        public static FrmMtoTipoContacto mtoTipoContacto = null;
        public static FrmMtoContacto mtoContacto = null;
        public static FrmMtoProveedor mtoProveedor = null;
        public static FrmMtoSucursal mtoSucursal = null;
        public static FrmMtoMoneda mtoMonea = null;
        public static FrmMtoCategoria mtoCategoria = null;
        public static FrmMtoTipoCategoria mtoTipoCategoria = null;
        public static FrmMtoProvincia mtoProvincia = null;
        public static FrmMtoEmpresa mtoEmpresa = null;
        public static FrmMtoPais mtoPais = null;
        public static FrmMtoIdentificacion mtoIdentificacion = null;
        public static FrmMtoTrabajo mtoTrabajo = null;
        //variables de control
        public static short codigoEmpresa = 1;
        public static short codigoTrabajo = 1;
        public static string nombreUsuario = "Maximo";
        public const string textoCuadroMensaje = "Neo";
        public static string mensajeElimina = "¿Esta seguro de eliminar?";       
    }
}
