﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18444
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace BusinessApplication1.Web.Resources {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class RegistrationDataResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal RegistrationDataResources() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("BusinessApplication1.Web.Resources.RegistrationDataResources", typeof(RegistrationDataResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   使用此强类型资源类，为所有资源查找
        ///   重写当前线程的 CurrentUICulture 属性。
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
        ///   查找类似 电子邮件 的本地化字符串。
        /// </summary>
        public static string EmailLabel {
            get {
                return ResourceManager.GetString("EmailLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 您希望在应用程序中显示您的用户名的方式 的本地化字符串。
        /// </summary>
        public static string FriendlyNameDescription {
            get {
                return ResourceManager.GetString("FriendlyNameDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 友好名称 的本地化字符串。
        /// </summary>
        public static string FriendlyNameLabel {
            get {
                return ResourceManager.GetString("FriendlyNameLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 确认密码 的本地化字符串。
        /// </summary>
        public static string PasswordConfirmationLabel {
            get {
                return ResourceManager.GetString("PasswordConfirmationLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 密码必须为 7 个字符长，且必须包含至少一个特殊字符，例如 @ 或 # 的本地化字符串。
        /// </summary>
        public static string PasswordDescription {
            get {
                return ResourceManager.GetString("PasswordDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 密码 的本地化字符串。
        /// </summary>
        public static string PasswordLabel {
            get {
                return ResourceManager.GetString("PasswordLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 安全提示问题的答案 的本地化字符串。
        /// </summary>
        public static string SecurityAnswerLabel {
            get {
                return ResourceManager.GetString("SecurityAnswerLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 安全提示问题 的本地化字符串。
        /// </summary>
        public static string SecurityQuestionLabel {
            get {
                return ResourceManager.GetString("SecurityQuestionLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 用户名 的本地化字符串。
        /// </summary>
        public static string UserNameLabel {
            get {
                return ResourceManager.GetString("UserNameLabel", resourceCulture);
            }
        }
    }
}