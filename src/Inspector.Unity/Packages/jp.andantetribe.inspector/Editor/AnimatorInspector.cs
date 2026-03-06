#nullable enable

using System;
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
        private readonly Lazy<GUIContent> _keepAnimatorStateStyle = new (static () =>
        {
            const string displayName = "Keep Animator State On Disable";
            const string tooltip = "Whether to preserve the AnimatorController state when the GameObject is disabled.";
            return EditorGUIUtility.TrTextContent(displayName + "|" + tooltip, displayName, tooltip, null);
        });

        private readonly Lazy<GUIContent> _writeDefaultValuesStyle = new (static () =>
        {
            const string displayName = "Write Default Values On Disable";
            const string tooltip = "Whether to write default values when the Animator is disabled.";
            return EditorGUIUtility.TrTextContent(displayName + "|" + tooltip, displayName, tooltip, null);
        });

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

            EditorGUILayout.PropertyField(_keepAnimatorStateOnDisable, _keepAnimatorStateStyle.Value);
            EditorGUILayout.PropertyField(_writeDefaultValuesOnDisable, _writeDefaultValuesStyle.Value);

            serializedObject.ApplyModifiedProperties();
        }
    }
}