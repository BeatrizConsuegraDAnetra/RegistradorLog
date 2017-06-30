//// -----------------------------------------------------------------------------------------
//// <copyright file="RegistrarLog.cs"7>
////     COPYRIGHT(C) 2017
//// </copyright>
//// <author>Beatriz Eugenia Consuegra D'Anetra</author>
//// <date>29/06/2017 -  10:50 a.m..</date>
//// <summary>
//// Define funcionalidades del registro del log dependiendo del tipo de registro y el tipo de mensaje.
////</summary>
//// -----------------------------------------------------------------------------------------

namespace RegistraLog.Clases
{
    using Entidades;
    using Globalizacion;
    using System;
    using System.Configuration;
    using System.IO;
    using System.Windows;

    public class RegistrarLog
    {
        private int tipoMensaje;
        private string mensaje;

        public void RegistraLog(int tipoMensaje, string mensaje, TipoRegistroMensaje tipoRegistroMensaje)
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

        public void RegistrarLogArchivo()
        {
            string rutaArchivoLog, nombreArchivoLog, rutaNombreCompletoArchivo;
            rutaArchivoLog = ConfigurationManager.AppSettings["LogFileDirectory"];
            nombreArchivoLog = string.Concat("LogFile", DateTime.Now.ToShortDateString(), ".txt");
            if (string.IsNullOrEmpty(rutaArchivoLog))
            {
                throw new ConfigurationErrorsException(MensajesGenerales.MensajeRutaNoConfigurada);
            }

            rutaNombreCompletoArchivo = string.Concat(rutaArchivoLog, nombreArchivoLog);

            if (!System.IO.Directory.Exists(rutaArchivoLog))
            {
                System.IO.Directory.CreateDirectory(rutaArchivoLog);
            }

            File.AppendAllText(rutaNombreCompletoArchivo, string.Concat(DateTime.Now.ToShortDateString(), mensaje));
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
            MessageBox.Show(
                mensaje, 
                MensajesGenerales.TituloVentanAdvertencia, 
                MessageBoxButton.OK, 
                MessageBoxImage.Warning);
        }

        private void DesplegarError()
        {
            MessageBox.Show(
                mensaje, 
                MensajesGenerales.TituloVentanaError, 
                MessageBoxButton.OK, 
                MessageBoxImage.Error);
        }

        private void DesplegarMensaje()
        {
            MessageBox.Show(
                mensaje, 
                MensajesGenerales.TituloVentanaMensaje, 
                MessageBoxButton.OK, 
                MessageBoxImage.Information);
        }

        public void RegistrarLogBaseDatos()
        {
            throw new NotImplementedException();
        }
    }
}