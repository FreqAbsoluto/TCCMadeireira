﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TCCMadeireira.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.7.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=192.168.15.2\\FQASQLSERVER;Initial Catalog=Madeireira;User ID=Otavio;P" +
            "assword=Otavio@435")]
        public string EscolaConnectionString {
            get {
                return ((string)(this["EscolaConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=desktop-fqa\\fqasqlserver;Initial Catalog=Madeireira;User ID=Otavio;Pa" +
            "ssword=Otavio@435")]
        public string CasaConnectionString {
            get {
                return ((string)(this["CasaConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=192.168.15.2\\FQASQLSERVER;Initial Catalog=Madeireira;User ID=Otavio;P" +
            "assword=Otavio@435")]
        public string CasaPWDConnectionString {
            get {
                return ((string)(this["CasaPWDConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=192.168.15.2\\FQASQLSERVER;Initial Catalog=Madeireira;User ID=Otavio;P" +
            "assword=Otavio@435")]
        public string db_04919_1_C_1_2017ConnectionString {
            get {
                return ((string)(this["db_04919_1_C_1_2017ConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=NOTE-FQA\\FQASQLSERVER;Initial Catalog=Madeireira;User ID=FQA;Password" +
            "=Otavio@435")]
        public string NoteConnectionString {
            get {
                return ((string)(this["NoteConnectionString"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("-1")]
        public int idUsuario {
            get {
                return ((int)(this["idUsuario"]));
            }
            set {
                this["idUsuario"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string nomeUsuario {
            get {
                return ((string)(this["nomeUsuario"]));
            }
            set {
                this["nomeUsuario"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string nivelUsuario {
            get {
                return ((string)(this["nivelUsuario"]));
            }
            set {
                this["nivelUsuario"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("desktop-fqa")]
        public string ServerName {
            get {
                return ((string)(this["ServerName"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Madeireira")]
        public string DBName {
            get {
                return ((string)(this["DBName"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Otavio")]
        public string LoginServer {
            get {
                return ((string)(this["LoginServer"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Otavio@435")]
        public string PwdServer {
            get {
                return ((string)(this["PwdServer"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("fqasqlserver")]
        public string ServerInstance {
            get {
                return ((string)(this["ServerInstance"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=desktop-fqa\\fqasqlserver;Initial Catalog=Madeireira;User ID=Otavio;Pa" +
            "ssword=Otavio@435")]
        public string MadeireiraConnectionString {
            get {
                return ((string)(this["MadeireiraConnectionString"]));
            }
        }
    }
}
