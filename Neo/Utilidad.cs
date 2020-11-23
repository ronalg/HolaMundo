using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neo
{
    class Utilidad
    {
        //formulario de busquedad
        public static FrmBscOrdenPedido bscOrdenPedido = null;
        //formulario transacciones
        public static FrmTscFactura tscFactura = null;
        public static FrmTscOrdenPedido tscOrdenPedido = null;
        //formularios mantenimientos
        //Veterinaria
        public static FrmMtoMascota mtoMascota = null;
        public static FrmMtoPelaje mtoPelaje = null;
        public static FrmMtoCaracter mtoCaracter = null;
        public static FrmMtoRaza mtoRaza = null;
        public static FrmMtoGrupoSanguineo mtoGrupoSanguineo = null;
        public static FrmMtoGrupo mtoGrupo = null;
        //-------------------------------------------------------------------------
        public static FrmMtoPuesto mtoPuesto = null;
        public static FrmMtoEmpleado mtoEmpleado = null;
        public static FrmMtoFrecuencia mtoFrecuencia = null;
        public static FrmMtoCliente mtoCliente = null;
        public static FrmMtoFinanciera mtoFinanciera = null;
        public static FrmMtoTipoFinanciera mtoTipoFinanciera = null;
        public static FrmMtoOcupacion mtoOcupacion = null;
        public static FrmMtoTipoTributo mtoTipoTributo = null;
        public static FrmMtoTributo mtoTributo = null;
        public static FrmMtoNacionalidad mtoNacionalidad = null;
        public static FrmMtoEstado mtoEstado = null;
        public static FrmMtoFormaPago mtoFormaPago = null;
        public static FrmMtoDepartamento mtoDepartamento = null;
        public static FrmMtoArticulo mtoArticulo = null;
        public static FrmMtoPrecioVenta mtoPrecioVenta = null;
        public static FrmMtoUnidad mtoUnidad = null;
        public static FrmMtoTipoContacto mtoTipoContacto = null;
        public static FrmMtoContacto mtoContacto = null;
        public static FrmMtoProveedor mtoProveedor = null;
        public static FrmMtoSucursal mtoSucursal = null;
        public static FrmMtoMoneda mtoMoneda = null;
        public static FrmMtoCategoria mtoCategoria = null;
        public static FrmMtoProvincia mtoProvincia = null;
        public static FrmMtoEmpresa mtoEmpresa = null;
        public static FrmMtoPais mtoPais = null;
        public static FrmMtoIdentificacion mtoIdentificacion = null;
        public static FrmMtoTrabajo mtoTrabajo = null;
        public static FrmPrm frmPrimario = null;
        //variables de control
        public static short codigoEmpresa = 0;
        public static short codigoTrabajo = 0;
        public static short codigoSucursal = 0;
        public static string nombreSucursal = null;
        public static short codigoUsuario = 0;
        public static string nombreUsuario = "Maximo";
        public const string textoCuadroMensaje = "Neo";
        public const string mensajeElimina = "¿Esta seguro de eliminar?";
        public const string campoVacio = "Ingrese valor";
        public const string listaVacia = "Seleccione un valor";
        public const string nombrePrograma = "Neo";
        public const string mensajeGuardado = "Se han guardado exitosamente";

        public static string Ceros(string valor)
        {
            string resultado = null;
            switch (valor.Length)
            {
                case 1:
                    resultado = string.Concat("000000", valor);
                    break;
                case 2:
                    resultado = string.Concat("00000", valor);
                    break;
                case 3:
                    resultado = string.Concat("0000", valor);
                    break;
                case 4:
                    resultado = string.Concat("000", valor);
                    break;
                case 5:
                    resultado = string.Concat("00", valor);
                    break;
                case 6:
                    resultado = string.Concat("0", valor);
                    break;
                default:
                    resultado = valor;
                    break;
            }

            return resultado;
        }

        public static int ValoMaxGrilla (DataGridView grilla, string columna)
        {
            int numero = 0;
            int filas = grilla.Rows.Count;
            if (filas > 0)
            {
                for (int i = 0; i < grilla.Rows.Count; i++)
                {
                    int valor1 = Convert.ToInt32(grilla.Rows[i].Cells[columna].Value.ToString());
                    numero = valor1;
                    for (int j = 0; j < grilla.Rows.Count; j++)
                    {
                        if (!string.IsNullOrEmpty(grilla.Rows[j].Cells[columna].Value.ToString()))
                        {
                            int valor2 = Convert.ToInt32(grilla.Rows[j].Cells[columna].Value.ToString());
                            if (valor2 > valor1)
                                numero = valor2;
                        }
                    }
                }
                numero++;
            }
            else
            {
                numero++;
            }
            return numero;
        }
    }
}
