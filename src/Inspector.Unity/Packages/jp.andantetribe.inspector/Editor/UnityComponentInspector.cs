#nullable enable

using UnityEditor;

namespace Inspector.Editor
{
    /// <summary>
    /// Base class for creating custom editors for existing Unity components.
    /// </summary>
    /// <typeparam name="T">Component type for which to create a custom editor.</typeparam>
    public abstract class UnityComponentInspector<T> : UnityEditor.Editor where T : UnityEngine.Component
    {
        private UnityEditor.Editor? _editor;

        /// <summary>
        /// Type name of the existing inspector class extension for the target component.
        /// </summary>
        protected abstract string InspectorTypeName { get; }

        /// <inheritdoc/>
        public override void OnInspectorGUI()
        {
            if (_editor != null)
            {
                _editor.OnInspectorGUI();
            }
        }

        private void OnEnable()
            => CreateCachedEditor(target, typeof(EditorApplication).Assembly.GetType(InspectorTypeName), ref _editor);

        private void OnDisable() => DestroyImmediate(_editor);
    }
}