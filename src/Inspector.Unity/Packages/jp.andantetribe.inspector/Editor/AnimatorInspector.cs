#nullable enable

using UnityEditor;
using UnityEngine;

namespace Inspector.Editor
{
    /// <summary>
    /// Custom editor for <see cref="Animator"/> that also allows editing
    /// <see cref="Animator.keepAnimatorStateOnDisable"/> and <see cref="Animator.writeDefaultValuesOnDisable"/>.
    /// </summary>
    [CustomEditor(typeof(Animator))]
    public class AnimatorInspector : UnityComponentInspector<Animator>
    {
        private SerializedProperty? _keepAnimatorStateOnDisable;
        private SerializedProperty? _writeDefaultValuesOnDisable;

        /// <inheritdoc/>
        protected override string InspectorTypeName => "UnityEditor.AnimatorInspector";

        /// <inheritdoc/>
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            _keepAnimatorStateOnDisable ??= serializedObject.FindProperty("m_KeepAnimatorStateOnDisable");
            _writeDefaultValuesOnDisable ??= serializedObject.FindProperty("m_WriteDefaultValuesOnDisable");

            const string keepAnimatorStateDisplayName = "Keep Animator State On Disable";
            const string keepAnimatorStateTooltip = "Whether to preserve the AnimatorController state when the GameObject is disabled.";
            var keepAnimatorStateContent = EditorGUIUtility.TrTextContent(
                keepAnimatorStateDisplayName + "|" + keepAnimatorStateTooltip,
                keepAnimatorStateDisplayName, keepAnimatorStateTooltip, null);
            EditorGUILayout.PropertyField(_keepAnimatorStateOnDisable, keepAnimatorStateContent);

            const string writeDefaultValuesDisplayName = "Write Default Values On Disable";
            const string writeDefaultValuesTooltip = "Whether to write default values when the Animator is disabled.";
            var writeDefaultValuesContent = EditorGUIUtility.TrTextContent(
                writeDefaultValuesDisplayName + "|" + writeDefaultValuesTooltip,
                writeDefaultValuesDisplayName, writeDefaultValuesTooltip, null);
            EditorGUILayout.PropertyField(_writeDefaultValuesOnDisable, writeDefaultValuesContent);

            serializedObject.ApplyModifiedProperties();
        }
    }
}