﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RegistraLog.Globalizacion {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class MensajesGenerales {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal MensajesGenerales() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("RegistraLog.Globalizacion.MensajesGenerales", typeof(MensajesGenerales).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Debe especificar un tipo de mensaje.
        /// </summary>
        public static string ConfiguracionTipoMensajeInvalida {
            get {
                return ResourceManager.GetString("ConfiguracionTipoMensajeInvalida", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Configuración Invalida.
        /// </summary>
        public static string ConfiguracionTipoRegistroInvalida {
            get {
                return ResourceManager.GetString("ConfiguracionTipoRegistroInvalida", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No se encontró la configuración de la ruta del archivo de log.
        /// </summary>
        public static string MensajeRutaNoConfigurada {
            get {
                return ResourceManager.GetString("MensajeRutaNoConfigurada", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Advertencia.
        /// </summary>
        public static string TituloVentanAdvertencia {
            get {
                return ResourceManager.GetString("TituloVentanAdvertencia", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error.
        /// </summary>
        public static string TituloVentanaError {
            get {
                return ResourceManager.GetString("TituloVentanaError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mensaje.
        /// </summary>
        public static string TituloVentanaMensaje {
            get {
                return ResourceManager.GetString("TituloVentanaMensaje", resourceCulture);
            }
        }
    }
}
