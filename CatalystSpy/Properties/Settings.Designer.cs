﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CatalystSpy.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("@KS@ROfgI4LimVc=")]
        public string userName {
            get {
                return ((string)(this["userName"]));
            }
            set {
                this["userName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("@KS@ROfgI4LimVc=")]
        public string passWord {
            get {
                return ((string)(this["passWord"]));
            }
            set {
                this["passWord"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0.4")]
        public double motionLevel {
            get {
                return ((double)(this["motionLevel"]));
            }
            set {
                this["motionLevel"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Threat Detected")]
        public string customWarningMessage {
            get {
                return ((string)(this["customWarningMessage"]));
            }
            set {
                this["customWarningMessage"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool isDirectoryHidden {
            get {
                return ((bool)(this["isDirectoryHidden"]));
            }
            set {
                this["isDirectoryHidden"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("D:\\CatalystSpy")]
        public string homeDirectory {
            get {
                return ((string)(this["homeDirectory"]));
            }
            set {
                this["homeDirectory"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("ftp://127.0.0.1/")]
        public string ftpIpAddress {
            get {
                return ((string)(this["ftpIpAddress"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("D:\\CatalystSpy\\Compressed")]
        public string compressedFileDirectory {
            get {
                return ((string)(this["compressedFileDirectory"]));
            }
            set {
                this["compressedFileDirectory"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("D:\\CatalystSpy\\Encrypted")]
        public string encryptedFilesDirectory {
            get {
                return ((string)(this["encryptedFilesDirectory"]));
            }
            set {
                this["encryptedFilesDirectory"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("D:\\CatalystSpy\\Decrypted")]
        public string decryptedFilesDirectory {
            get {
                return ((string)(this["decryptedFilesDirectory"]));
            }
            set {
                this["decryptedFilesDirectory"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool isShowMotionInPlayer {
            get {
                return ((bool)(this["isShowMotionInPlayer"]));
            }
            set {
                this["isShowMotionInPlayer"] = value;
            }
        }
    }
}
