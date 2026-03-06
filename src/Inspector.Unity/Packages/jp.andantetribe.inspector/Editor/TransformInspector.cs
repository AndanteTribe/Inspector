#nullable enable

using UnityEditor;
using UnityEngine;

namespace Inspector.Editor
{
    /// <summary>
    /// Custom editor for <see cref="Transform"/> that also displays world position, rotation, and scale.
    /// </summary>
    [CustomEditor(typeof(Transform))]
    public class TransformInspector : UnityComponentInspector<Transform>
    {
        /// <inheritdoc/>
        protected override string InspectorTypeName => "UnityEditor.TransformInspector";

        /// <inheritdoc/>
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            var transform = (Transform)target;
            transform.position = EditorGUILayout.Vector3Field("World Position", transform.position);
            using (new EditorGUI.DisabledScope(true))
            {
                EditorGUILayout.Vector3Field("World Rotation", transform.rotation.eulerAngles);
                EditorGUILayout.Vector3Field("World Scale", transform.lossyScale);
            }
        }
    }
}