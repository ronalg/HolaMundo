﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neo
{
    class Utilidad
    {
        //formularios mantenimientos
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
        public static short codigoEmpresa = 1;
        public static short codigoTrabajo = 1;
        public static string nombreUsuario = "Maximo";
        public const string textoCuadroMensaje = "Neo";
        public const string mensajeElimina = "¿Esta seguro de eliminar?";
        public const string campoVacio = "Ingrese valor";
        public const string listaVacia = "Seleccione un valor";
    }
}
