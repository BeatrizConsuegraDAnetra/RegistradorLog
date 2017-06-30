//// -----------------------------------------------------------------------------------------
//// <copyright file="UtilidadesApp.cs"7>
////     COPYRIGHT(C) 20177
//// </copyright>
//// <author>Beatriz Eugenia Consuegra D'Anetra</author>
//// <date>29/06/2017 -  10:50 a.m..</date>
//// <summary>Define funcionalidades generales dentro del contexto de la aplicación.</summary>
//// -----------------------------------------------------------------------------------------

namespace Utilidades
{
    using Entidades;
    using Globalizacion;
    using System;

    public class RegistradorLog
    {
        private int tipoMensaje;
        private string mensaje;

        public void RegistrarLog(int tipoMensaje, string mensaje, TipoRegistroMensaje tipoRegistroMensaje)
        {
            if (string.IsNullOrEmpty(mensaje))
            {
                return;
            }

            if (!this.ValidarTipoRegistroMensaje(tipoRegistroMensaje))
            {
                throw new ArgumentException(MensajesGenerales.ConfiguracionTipoRegistroInvalida);
            }

            if (tipoMensaje == 0)
            {
                throw new ArgumentException(MensajesGenerales.ConfiguracionTipoMensajeInvalida);
            }

            this.tipoMensaje = tipoMensaje;
            this.mensaje = mensaje;
            if (tipoRegistroMensaje.registraLogArchivo)
            {
                this.RegistrarLogArchivo();
            }

            if (tipoRegistroMensaje.registraLogBaseDatos)
            {
                this.RegistrarLogBaseDatos();
            }

            if (tipoRegistroMensaje.despliegaMensajeConsola)
            {
                this.DesplegarMensajeConsola();
            }

        }

        private bool ValidarTipoRegistroMensaje(TipoRegistroMensaje tipoRegistroMensaje)
        {
            bool resultadoValidacion = true;
            if (tipoRegistroMensaje == null ||
                (!tipoRegistroMensaje.registraLogArchivo &&
                !tipoRegistroMensaje.registraLogBaseDatos &&
                !tipoRegistroMensaje.despliegaMensajeConsola))
            {
                resultadoValidacion = false;
            }

            return resultadoValidacion;
        }

        /// <summary>
        /// Registra una excepción en el log de errores establecido.
        /// </summary>
        /// <param name="excepcion">Información de la excepción generada.</param>
        /// <param name="politicaExcepcion">Política establecida para la excepción.</param>
        //// <author>Beatriz Eugenia Consuegra D'Anetra</author>
        //// <date>29/06/2017 -  10:50 a.m..</date>
        public void RegistrarLogArchivo()
        {

        }

        public void DesplegarMensajeConsola()
        {
            switch (this.tipoMensaje)
            {
                case 1:
                    this.DesplegarMensaje();
                    break;
                case 2:
                    this.DesplegarAdvertencia();
                    break;
                case 3:
                    this.DesplegarError();
                    break;
                default:
                    break;
            }
        }

        private void DesplegarAdvertencia()
        {
            
        }

        private void DesplegarError()
        {
            throw new NotImplementedException();
        }

        private void DesplegarMensaje()
        {
            throw new NotImplementedException();
        }

        public void RegistrarLogBaseDatos()
        {

        }
    }
}
