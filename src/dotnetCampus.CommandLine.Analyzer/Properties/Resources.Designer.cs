﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace dotnetCampus.CommandLine.Properties {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("dotnetCampus.CommandLine.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   重写当前线程的 CurrentUICulture 属性
        ///   重写当前线程的 CurrentUICulture 属性。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似 Use &apos;bool&apos; type instead 的本地化字符串。
        /// </summary>
        internal static string ConvertOptionPropertyTypeToBooleanFix {
            get {
                return ResourceManager.GetString("ConvertOptionPropertyTypeToBooleanFix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Use `IReadOnlyDictionary&lt;string, string&gt;` type instead 的本地化字符串。
        /// </summary>
        internal static string ConvertOptionPropertyTypeToDictionaryFix {
            get {
                return ResourceManager.GetString("ConvertOptionPropertyTypeToDictionaryFix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Use &apos;DirectoryInfo&apos; type instead 的本地化字符串。
        /// </summary>
        internal static string ConvertOptionPropertyTypeToDirectoryInfoFix {
            get {
                return ResourceManager.GetString("ConvertOptionPropertyTypeToDirectoryInfoFix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Use &apos;double&apos; type instead 的本地化字符串。
        /// </summary>
        internal static string ConvertOptionPropertyTypeToDoubleFix {
            get {
                return ResourceManager.GetString("ConvertOptionPropertyTypeToDoubleFix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Use &apos;FileInfo&apos; type instead 的本地化字符串。
        /// </summary>
        internal static string ConvertOptionPropertyTypeToFileInfoFix {
            get {
                return ResourceManager.GetString("ConvertOptionPropertyTypeToFileInfoFix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Use &apos;int&apos; type instead 的本地化字符串。
        /// </summary>
        internal static string ConvertOptionPropertyTypeToInt32Fix {
            get {
                return ResourceManager.GetString("ConvertOptionPropertyTypeToInt32Fix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Use `IReadOnlyList&lt;string&gt;` type instead 的本地化字符串。
        /// </summary>
        internal static string ConvertOptionPropertyTypeToListFix {
            get {
                return ResourceManager.GetString("ConvertOptionPropertyTypeToListFix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Use &apos;string&apos; type instead 的本地化字符串。
        /// </summary>
        internal static string ConvertOptionPropertyTypeToStringFix {
            get {
                return ResourceManager.GetString("ConvertOptionPropertyTypeToStringFix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 This property has the type &apos;{0}&apos; which is not built-in supported. It&apos;s recommended to use bool/string/IList&lt;string&gt; or other types that the code fix will suggest you change instead or add a custom converter on your Value or Option attribute. 的本地化字符串。
        /// </summary>
        internal static string NotSupportedOptionPropertyTypeDescription {
            get {
                return ResourceManager.GetString("NotSupportedOptionPropertyTypeDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 This property has the type &apos;{0}&apos; which is not built-in supported. 的本地化字符串。
        /// </summary>
        internal static string NotSupportedOptionPropertyTypeMessage {
            get {
                return ResourceManager.GetString("NotSupportedOptionPropertyTypeMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Not supported property type 的本地化字符串。
        /// </summary>
        internal static string NotSupportedOptionPropertyTypeTitle {
            get {
                return ResourceManager.GetString("NotSupportedOptionPropertyTypeTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The command-line option definition names must be PascalCase, even though you can use any kind of style in the command line environment. 的本地化字符串。
        /// </summary>
        internal static string OptionLongNameMustBePascalCaseDescription {
            get {
                return ResourceManager.GetString("OptionLongNameMustBePascalCaseDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Convert to PascalCase 的本地化字符串。
        /// </summary>
        internal static string OptionLongNameMustBePascalCaseFix {
            get {
                return ResourceManager.GetString("OptionLongNameMustBePascalCaseFix", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The option definition long name &apos;{0}&apos; must be PascalCase, even though you can use any kind of style in the command line environment. 的本地化字符串。
        /// </summary>
        internal static string OptionLongNameMustBePascalCaseMessage {
            get {
                return ResourceManager.GetString("OptionLongNameMustBePascalCaseMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Option long name must be PascalCase 的本地化字符串。
        /// </summary>
        internal static string OptionLongNameMustBePascalCaseTitle {
            get {
                return ResourceManager.GetString("OptionLongNameMustBePascalCaseTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 This property has a recommended option property type &apos;{0}&apos;. 的本地化字符串。
        /// </summary>
        internal static string SupportedOptionPropertyTypeDescription {
            get {
                return ResourceManager.GetString("SupportedOptionPropertyTypeDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 This property has a recommended option property type &apos;{0}&apos;. 的本地化字符串。
        /// </summary>
        internal static string SupportedOptionPropertyTypeMessage {
            get {
                return ResourceManager.GetString("SupportedOptionPropertyTypeMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Recommended option property type 的本地化字符串。
        /// </summary>
        internal static string SupportedOptionPropertyTypeTitle {
            get {
                return ResourceManager.GetString("SupportedOptionPropertyTypeTitle", resourceCulture);
            }
        }
    }
}
