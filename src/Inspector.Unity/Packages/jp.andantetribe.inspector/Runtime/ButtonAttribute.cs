#nullable enable

using System;
using System.Diagnostics;

namespace Inspector
{
    /// <summary>
    /// Attribute that enables invoking the specified method from a button shown in the Unity Inspector.
    /// </summary>
    [Conditional("UNITY_EDITOR")]
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public sealed class ButtonAttribute : Attribute
    {
        /// <summary>
        /// Arguments.
        /// </summary>
        public readonly object[] Parameters;

        /// <summary>
        /// Button label.
        /// </summary>
        public readonly string ButtonName;

        /// <summary>
        /// Initializes a new instance of the <see cref="ButtonAttribute"/> class.
        /// </summary>
        /// <param name="buttonName">Button label. The default value is the target method name.</param>
        /// <param name="parameters">Arguments.</param>
        public ButtonAttribute(string buttonName = "", params object[] parameters)
        {
            ButtonName = buttonName;
            Parameters = parameters;
        }
    }
}