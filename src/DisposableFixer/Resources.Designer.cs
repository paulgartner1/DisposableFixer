﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DisposableFixer {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
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
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DisposableFixer.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to This disposable is not disposed..
        /// </summary>
        internal static string AnalyzerDescription {
            get {
                return ResourceManager.GetString("AnalyzerDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MethodInvocation returns an anonymous object that is not disposed..
        /// </summary>
        internal static string AnonymousObjectFromMethodInvocationDescription {
            get {
                return ResourceManager.GetString("AnonymousObjectFromMethodInvocationDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Undisposed anonymous object..
        /// </summary>
        internal static string AnonymousObjectFromMethodInvocationMessageFormat {
            get {
                return ResourceManager.GetString("AnonymousObjectFromMethodInvocationMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Marks undisposed anonymous objects from method invocations..
        /// </summary>
        internal static string AnonymousObjectFromMethodInvocationTitle {
            get {
                return ResourceManager.GetString("AnonymousObjectFromMethodInvocationTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Undisposed anonymous object..
        /// </summary>
        internal static string AnonymousObjectFromObjectCreationDescription {
            get {
                return ResourceManager.GetString("AnonymousObjectFromObjectCreationDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This ObjectCreation returns an object that is not disposed..
        /// </summary>
        internal static string AnonymousObjectFromObjectCreationMessageFormat {
            get {
                return ResourceManager.GetString("AnonymousObjectFromObjectCreationMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Marks undisposed anonymous objects from object creations..
        /// </summary>
        internal static string AnonymousObjectFromObjectCreationTitle {
            get {
                return ResourceManager.GetString("AnonymousObjectFromObjectCreationTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Result of method invocation is assigned to a field that is never disposed..
        /// </summary>
        internal static string AssignmendFromMethodInvocationToFieldOfAnotherTypeNotDisposedDescription {
            get {
                return ResourceManager.GetString("AssignmendFromMethodInvocationToFieldOfAnotherTypeNotDisposedDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Previous value of field &apos;{0}.{1}&apos; might no be disposed..
        /// </summary>
        internal static string AssignmendFromMethodInvocationToFieldOfAnotherTypeNotDisposedMessageFormat {
            get {
                return ResourceManager.GetString("AssignmendFromMethodInvocationToFieldOfAnotherTypeNotDisposedMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Marks undisposed objects assinged to a field, originated from method invocation..
        /// </summary>
        internal static string AssignmendFromMethodInvocationToFieldOfAnotherTypeNotDisposedTitle {
            get {
                return ResourceManager.GetString("AssignmendFromMethodInvocationToFieldOfAnotherTypeNotDisposedTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Result of method invocation is assigned to a field that is never disposed..
        /// </summary>
        internal static string AssignmendFromMethodInvocationToFieldOfSameTypeNotDisposedDescription {
            get {
                return ResourceManager.GetString("AssignmendFromMethodInvocationToFieldOfSameTypeNotDisposedDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Field &apos;{0}&apos; is not disposed..
        /// </summary>
        internal static string AssignmendFromMethodInvocationToFieldOfSameTypeNotDisposedMessageFormat {
            get {
                return ResourceManager.GetString("AssignmendFromMethodInvocationToFieldOfSameTypeNotDisposedMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Marks undisposed objects assinged to a field, originated from method invocation..
        /// </summary>
        internal static string AssignmendFromMethodInvocationToFieldOfSameTypeNotDisposedTitle {
            get {
                return ResourceManager.GetString("AssignmendFromMethodInvocationToFieldOfSameTypeNotDisposedTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Result of method invocation is assigned to a property that is never disposed..
        /// </summary>
        internal static string AssignmendFromMethodInvocationToPropertyOfAnotherTypeNotDisposedDescription {
            get {
                return ResourceManager.GetString("AssignmendFromMethodInvocationToPropertyOfAnotherTypeNotDisposedDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Previous value of property &apos;{0}&apos; might no be disposed..
        /// </summary>
        internal static string AssignmendFromMethodInvocationToPropertyOfAnotherTypeNotDisposedMessageFormat {
            get {
                return ResourceManager.GetString("AssignmendFromMethodInvocationToPropertyOfAnotherTypeNotDisposedMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Marks undisposed objects assinged to a property, originated from a method invocation..
        /// </summary>
        internal static string AssignmendFromMethodInvocationToPropertyOfAnotherTypeNotDisposedTitle {
            get {
                return ResourceManager.GetString("AssignmendFromMethodInvocationToPropertyOfAnotherTypeNotDisposedTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Result of method invocation is assigned to a property that is never disposed..
        /// </summary>
        internal static string AssignmendFromMethodInvocationToPropertyOfSameTypeNotDisposedDescription {
            get {
                return ResourceManager.GetString("AssignmendFromMethodInvocationToPropertyOfSameTypeNotDisposedDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Property &apos;{0}&apos; is not disposed..
        /// </summary>
        internal static string AssignmendFromMethodInvocationToPropertyOfSameTypeNotDisposedMessageFormat {
            get {
                return ResourceManager.GetString("AssignmendFromMethodInvocationToPropertyOfSameTypeNotDisposedMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Marks undisposed objects assinged to a property, originated from a method invocation..
        /// </summary>
        internal static string AssignmendFromMethodInvocationToPropertyOfSameTypeNotDisposedTitle {
            get {
                return ResourceManager.GetString("AssignmendFromMethodInvocationToPropertyOfSameTypeNotDisposedTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Result of method invocation is assigned to a field that is never disposed..
        /// </summary>
        internal static string AssignmendFromMethodInvocationToStaticFieldOfAnotherTypeNotDisposedDescription {
            get {
                return ResourceManager.GetString("AssignmendFromMethodInvocationToStaticFieldOfAnotherTypeNotDisposedDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Previous value of static field &apos;{0}.{1}&apos; might no be disposed..
        /// </summary>
        internal static string AssignmendFromMethodInvocationToStaticFieldOfAnotherTypeNotDisposedMessageFormat {
            get {
                return ResourceManager.GetString("AssignmendFromMethodInvocationToStaticFieldOfAnotherTypeNotDisposedMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Marks undisposed objects assinged to a field, originated from method invocation..
        /// </summary>
        internal static string AssignmendFromMethodInvocationToStaticFieldOfAnotherTypeNotDisposedTitle {
            get {
                return ResourceManager.GetString("AssignmendFromMethodInvocationToStaticFieldOfAnotherTypeNotDisposedTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Result of method invocation is assigned to a field that is never disposed..
        /// </summary>
        internal static string AssignmendFromMethodInvocationToStaticFieldOfSameTypeNotDisposedDescription {
            get {
                return ResourceManager.GetString("AssignmendFromMethodInvocationToStaticFieldOfSameTypeNotDisposedDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Static field &apos;{0}&apos; is not disposed..
        /// </summary>
        internal static string AssignmendFromMethodInvocationToStaticFieldOfSameTypeNotDisposedMessageFormat {
            get {
                return ResourceManager.GetString("AssignmendFromMethodInvocationToStaticFieldOfSameTypeNotDisposedMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Marks undisposed objects assinged to a field, originated from method invocation..
        /// </summary>
        internal static string AssignmendFromMethodInvocationToStaticFieldOfSameTypeNotDisposedTitle {
            get {
                return ResourceManager.GetString("AssignmendFromMethodInvocationToStaticFieldOfSameTypeNotDisposedTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Result of method invocation is assigned to a property that is never disposed..
        /// </summary>
        internal static string AssignmendFromMethodInvocationToStaticPropertyOfAnotherTypeNotDisposedDescription {
            get {
                return ResourceManager.GetString("AssignmendFromMethodInvocationToStaticPropertyOfAnotherTypeNotDisposedDescription" +
                        "", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Previous value of static property &apos;{0}&apos; might no be disposed..
        /// </summary>
        internal static string AssignmendFromMethodInvocationToStaticPropertyOfAnotherTypeNotDisposedMessageFormat {
            get {
                return ResourceManager.GetString("AssignmendFromMethodInvocationToStaticPropertyOfAnotherTypeNotDisposedMessageForm" +
                        "at", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Marks undisposed objects assinged to a property, originated from a method invocation..
        /// </summary>
        internal static string AssignmendFromMethodInvocationToStaticPropertyOfAnotherTypeNotDisposedTitle {
            get {
                return ResourceManager.GetString("AssignmendFromMethodInvocationToStaticPropertyOfAnotherTypeNotDisposedTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Result of method invocation is assigned to a property that is never disposed..
        /// </summary>
        internal static string AssignmendFromMethodInvocationToStaticPropertyOfSameTypeNotDisposedDescription {
            get {
                return ResourceManager.GetString("AssignmendFromMethodInvocationToStaticPropertyOfSameTypeNotDisposedDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Static property &apos;{0}&apos; is not disposed..
        /// </summary>
        internal static string AssignmendFromMethodInvocationToStaticPropertyOfSameTypeNotDisposedMessageFormat {
            get {
                return ResourceManager.GetString("AssignmendFromMethodInvocationToStaticPropertyOfSameTypeNotDisposedMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Marks undisposed objects assinged to a property, originated from a method invocation..
        /// </summary>
        internal static string AssignmendFromMethodInvocationToStaticPropertyOfSameTypeNotDisposedTitle {
            get {
                return ResourceManager.GetString("AssignmendFromMethodInvocationToStaticPropertyOfSameTypeNotDisposedTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Result of object creation is assigned to a field that is never disposed..
        /// </summary>
        internal static string AssignmendFromObjectCreationToFieldOfAnotherTypeNotDisposedDescription {
            get {
                return ResourceManager.GetString("AssignmendFromObjectCreationToFieldOfAnotherTypeNotDisposedDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Previous value of field &apos;{0}.{1}&apos; might no be disposed..
        /// </summary>
        internal static string AssignmendFromObjectCreationToFieldOfAnotherTypeNotDisposedMessageFormat {
            get {
                return ResourceManager.GetString("AssignmendFromObjectCreationToFieldOfAnotherTypeNotDisposedMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Marks undisposed objects assinged to a field, originated in an object creation..
        /// </summary>
        internal static string AssignmendFromObjectCreationToFieldOfAnotherTypeNotDisposedTitle {
            get {
                return ResourceManager.GetString("AssignmendFromObjectCreationToFieldOfAnotherTypeNotDisposedTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Result of object creation is assigned to a field that is never disposed..
        /// </summary>
        internal static string AssignmendFromObjectCreationToFieldOfSameTypeNotDisposedDescription {
            get {
                return ResourceManager.GetString("AssignmendFromObjectCreationToFieldOfSameTypeNotDisposedDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Field &apos;{0}&apos; is not disposed..
        /// </summary>
        internal static string AssignmendFromObjectCreationToFieldOfSameTypeNotDisposedMessageFormat {
            get {
                return ResourceManager.GetString("AssignmendFromObjectCreationToFieldOfSameTypeNotDisposedMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Marks undisposed objects assinged to a field, originated in an object creation..
        /// </summary>
        internal static string AssignmendFromObjectCreationToFieldOfSameTypeNotDisposedTitle {
            get {
                return ResourceManager.GetString("AssignmendFromObjectCreationToFieldOfSameTypeNotDisposedTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Result of object creation is assigned to a property that is never disposed..
        /// </summary>
        internal static string AssignmendFromObjectCreationToPropertyOfAnotherTypeNotDisposedDescription {
            get {
                return ResourceManager.GetString("AssignmendFromObjectCreationToPropertyOfAnotherTypeNotDisposedDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Previous value of property &apos;{0}&apos; might no be disposed..
        /// </summary>
        internal static string AssignmendFromObjectCreationToPropertyOfAnotherTypeNotDisposedMessageFormat {
            get {
                return ResourceManager.GetString("AssignmendFromObjectCreationToPropertyOfAnotherTypeNotDisposedMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Marks undisposed objects assinged to a property, originated in an object creation..
        /// </summary>
        internal static string AssignmendFromObjectCreationToPropertyOfAnotherTypeNotDisposedTitle {
            get {
                return ResourceManager.GetString("AssignmendFromObjectCreationToPropertyOfAnotherTypeNotDisposedTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Result of object creation is assigned to a property that is never disposed..
        /// </summary>
        internal static string AssignmendFromObjectCreationToPropertyOfSameTypeNotDisposedDescription {
            get {
                return ResourceManager.GetString("AssignmendFromObjectCreationToPropertyOfSameTypeNotDisposedDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Property &apos;{0}&apos; is not disposed..
        /// </summary>
        internal static string AssignmendFromObjectCreationToPropertyOfSameTypeNotDisposedMessageFormat {
            get {
                return ResourceManager.GetString("AssignmendFromObjectCreationToPropertyOfSameTypeNotDisposedMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Marks undisposed objects assinged to a property, originated in an object creation..
        /// </summary>
        internal static string AssignmendFromObjectCreationToPropertyOfSameTypeNotDisposedTitle {
            get {
                return ResourceManager.GetString("AssignmendFromObjectCreationToPropertyOfSameTypeNotDisposedTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Result of object creation is assigned to a field that is never disposed..
        /// </summary>
        internal static string AssignmendFromObjectCreationToStaticFieldOfAnotherTypeNotDisposedDescription {
            get {
                return ResourceManager.GetString("AssignmendFromObjectCreationToStaticFieldOfAnotherTypeNotDisposedDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Previous value of static field &apos;{0}.{1}&apos; might no be disposed..
        /// </summary>
        internal static string AssignmendFromObjectCreationToStaticFieldOfAnotherTypeNotDisposedMessageFormat {
            get {
                return ResourceManager.GetString("AssignmendFromObjectCreationToStaticFieldOfAnotherTypeNotDisposedMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Marks undisposed objects assinged to a field, originated in an object creation..
        /// </summary>
        internal static string AssignmendFromObjectCreationToStaticFieldOfAnotherTypeNotDisposedTitle {
            get {
                return ResourceManager.GetString("AssignmendFromObjectCreationToStaticFieldOfAnotherTypeNotDisposedTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Result of object creation is assigned to a field that is never disposed..
        /// </summary>
        internal static string AssignmendFromObjectCreationToStaticFieldOfSameTypeNotDisposedDescription {
            get {
                return ResourceManager.GetString("AssignmendFromObjectCreationToStaticFieldOfSameTypeNotDisposedDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Static field &apos;{0}&apos; is not disposed..
        /// </summary>
        internal static string AssignmendFromObjectCreationToStaticFieldOfSameTypeNotDisposedMessageFormat {
            get {
                return ResourceManager.GetString("AssignmendFromObjectCreationToStaticFieldOfSameTypeNotDisposedMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Marks undisposed objects assinged to a field, originated in an object creation..
        /// </summary>
        internal static string AssignmendFromObjectCreationToStaticFieldOfSameTypeNotDisposedTitle {
            get {
                return ResourceManager.GetString("AssignmendFromObjectCreationToStaticFieldOfSameTypeNotDisposedTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Result of object creation is assigned to a property that is never disposed..
        /// </summary>
        internal static string AssignmendFromObjectCreationToStaticPropertyOfAnotherTypeNotDisposedDescription {
            get {
                return ResourceManager.GetString("AssignmendFromObjectCreationToStaticPropertyOfAnotherTypeNotDisposedDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Previous value of static property &apos;{0}&apos; might no be disposed..
        /// </summary>
        internal static string AssignmendFromObjectCreationToStaticPropertyOfAnotherTypeNotDisposedMessageFormat {
            get {
                return ResourceManager.GetString("AssignmendFromObjectCreationToStaticPropertyOfAnotherTypeNotDisposedMessageFormat" +
                        "", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Marks undisposed objects assinged to a property, originated in an object creation..
        /// </summary>
        internal static string AssignmendFromObjectCreationToStaticPropertyOfAnotherTypeNotDisposedTitle {
            get {
                return ResourceManager.GetString("AssignmendFromObjectCreationToStaticPropertyOfAnotherTypeNotDisposedTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Result of object creation is assigned to a property that is never disposed..
        /// </summary>
        internal static string AssignmendFromObjectCreationToStaticPropertyOfSameTypeNotDisposedDescription {
            get {
                return ResourceManager.GetString("AssignmendFromObjectCreationToStaticPropertyOfSameTypeNotDisposedDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Static property &apos;{0}&apos; is not disposed..
        /// </summary>
        internal static string AssignmendFromObjectCreationToStaticPropertyOfSameTypeNotDisposedMessageFormat {
            get {
                return ResourceManager.GetString("AssignmendFromObjectCreationToStaticPropertyOfSameTypeNotDisposedMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Marks undisposed objects assinged to a property, originated in an object creation..
        /// </summary>
        internal static string AssignmendFromObjectCreationToStaticPropertyOfSameTypeNotDisposedTitle {
            get {
                return ResourceManager.GetString("AssignmendFromObjectCreationToStaticPropertyOfSameTypeNotDisposedTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This dispose method contains no statements and can safely be removed..
        /// </summary>
        internal static string EmptyDisposableDescription {
            get {
                return ResourceManager.GetString("EmptyDisposableDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This dispose method contains no statements and can safely be removed..
        /// </summary>
        internal static string EmptyDisposableMessageFormat {
            get {
                return ResourceManager.GetString("EmptyDisposableMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Marks an Dispose implementation that is not in use..
        /// </summary>
        internal static string EmptyDisposableTitle {
            get {
                return ResourceManager.GetString("EmptyDisposableTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to IDisposable implementation can&apos;t be seen by caller..
        /// </summary>
        internal static string HiddenDisposableDescription {
            get {
                return ResourceManager.GetString("HiddenDisposableDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; implements IDisposable but return type &apos;{1}&apos; of &apos;{2}&apos; does not..
        /// </summary>
        internal static string HiddenDisposableMessageFormat {
            get {
                return ResourceManager.GetString("HiddenDisposableMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Marks return values that hides the IDisposable implementation of return value..
        /// </summary>
        internal static string HiddenDisposableTitle {
            get {
                return ResourceManager.GetString("HiddenDisposableTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Marks factory property that creates an IDisposable without tracking it..
        /// </summary>
        internal static string NotDisposedFactoryPropertyDescription {
            get {
                return ResourceManager.GetString("NotDisposedFactoryPropertyDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Factory properties &apos;{0}&apos; cannot be disposed. It recommended to change this to a factory method..
        /// </summary>
        internal static string NotDisposedFactoryPropertyMessageFormat {
            get {
                return ResourceManager.GetString("NotDisposedFactoryPropertyMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Marks undisposed factory properties..
        /// </summary>
        internal static string NotDisposedFactoryPropertyTitle {
            get {
                return ResourceManager.GetString("NotDisposedFactoryPropertyTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Marks static factory property that creates an IDisposable without tracking it..
        /// </summary>
        internal static string NotDisposedFactoryStaticPropertyDescription {
            get {
                return ResourceManager.GetString("NotDisposedFactoryStaticPropertyDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Static factory property &apos;{0}&apos; cannot be disposed. It recommended to change this to a static factory method..
        /// </summary>
        internal static string NotDisposedFactoryStaticPropertyMessageFormat {
            get {
                return ResourceManager.GetString("NotDisposedFactoryStaticPropertyMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Marks undisposed static factory properties..
        /// </summary>
        internal static string NotDisposedFactoryStaticPropertyTitle {
            get {
                return ResourceManager.GetString("NotDisposedFactoryStaticPropertyTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Undisposed local variables.
        /// </summary>
        internal static string NotDisposedLocalVariableDescription {
            get {
                return ResourceManager.GetString("NotDisposedLocalVariableDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Local variable &apos;{0}&apos; is not disposed.
        /// </summary>
        internal static string NotDisposedLocalVariableMessageFormat {
            get {
                return ResourceManager.GetString("NotDisposedLocalVariableMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Marks undisposed local variables..
        /// </summary>
        internal static string NotDisposedLocalVariableTitle {
            get {
                return ResourceManager.GetString("NotDisposedLocalVariableTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This disposable is not disposed..
        /// </summary>
        internal static string NotDisposedMessageFormat {
            get {
                return ResourceManager.GetString("NotDisposedMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Marks tuple elements that don&apos;t get disposed..
        /// </summary>
        internal static string NotDisposedTupleElementDescription {
            get {
                return ResourceManager.GetString("NotDisposedTupleElementDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tuple element &apos;{0}&apos; is not disposed.
        /// </summary>
        internal static string NotDisposedTupleElementMessageFormat {
            get {
                return ResourceManager.GetString("NotDisposedTupleElementMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Marks undiposed tuple elements.
        /// </summary>
        internal static string NotDisposedTupleElementTitle {
            get {
                return ResourceManager.GetString("NotDisposedTupleElementTitle", resourceCulture);
            }
        }
    }
}
