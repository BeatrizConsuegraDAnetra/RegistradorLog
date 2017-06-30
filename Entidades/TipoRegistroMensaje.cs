//// ----------------------------------------------------------------------------------
//// <copyright file="TipoRegistroMensaje.cs">
//// COPYRIGHT(C) 2017
//// </copyright>
//// <author>Beatriz Eugenia Consuegra D'Anetra</author>
//// <date>29/06/2017 -  10:50 a.m..</date>
//// <summary>Entidad que almacena los tipos de registros que se deben emplear.</summary>
//// ----------------------------------------------------------------------------------

using System;

namespace Entidades
{
    public class TipoRegistroMensaje
    {
        [STAThread]
        static void Main()
        {
        }

        public bool registraLogArchivo { get; set; }

        public bool registraLogBaseDatos { get; set; }

        public bool despliegaMensajeConsola { get; set; }
    }
}
