﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System.Runtime.InteropServices.Analyzers {
    using System;
    using System.Reflection;
    
    
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
    internal class SystemRuntimeInteropServicesAnalyzersResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SystemRuntimeInteropServicesAnalyzersResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("System.Runtime.InteropServices.Analyzers.SystemRuntimeInteropServicesAnalyzersRes" +
                            "ources", typeof(SystemRuntimeInteropServicesAnalyzersResources).GetTypeInfo().Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Make the P\Invoke method internal.
        /// </summary>
        internal static string MarkPInvokeMethodAsInternal {
            get {
                return ResourceManager.GetString("MarkPInvokeMethodAsInternal", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Move P/Invokes to native methods class.
        /// </summary>
        internal static string MovePInvokesToNativeMethodsClass {
            get {
                return ResourceManager.GetString("MovePInvokesToNativeMethodsClass", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to P/Invoke method &apos;{0}&apos; should not be visible.
        /// </summary>
        internal static string PInvokeMethodShouldNotBeVisible {
            get {
                return ResourceManager.GetString("PInvokeMethodShouldNotBeVisible", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to P/Invokes should not be visible..
        /// </summary>
        internal static string PInvokesShouldNotBeVisible {
            get {
                return ResourceManager.GetString("PInvokesShouldNotBeVisible", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specify marshaling for P/Invoke string arguments.
        /// </summary>
        internal static string SpecifyMarshalingForPInvokeStringArguments {
            get {
                return ResourceManager.GetString("SpecifyMarshalingForPInvokeStringArguments", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to When marshaling strings as ANSI (or as Auto on Win9x), some characters may be changed. If best-fit mapping is on, strings that appear different in Unicode will be marshaled to identical ANSI strings, which may lead to incorrect security decisions. Turning best-fit mapping off reduces this risk, as all characters without equivalents are mapped to &apos;?&apos;. Also, note that CharSet.Ansi is the default setting for all string marshaling; Unicode marshaling must be specified explicitly, either as a CharSet setting of  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SpecifyMarshalingForPInvokeStringArgumentsDescription {
            get {
                return ResourceManager.GetString("SpecifyMarshalingForPInvokeStringArgumentsDescription", resourceCulture);
            }
        }
    }
}
