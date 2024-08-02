using UnityEngine;

namespace CaffeinatedStudios.ScriptableObjectArchitecture
{
    [CreateAssetMenu(fileName = "Vector3Variable", menuName = "Variables/Vector3 Variable")]
    public class Vector3Variable : ScriptableObject
    {
#if UNITY_EDITOR
        [Multiline]
        public string DeveloperDescription = "";
#endif

        public Vector3 Value;

        public void SetValue(Vector3 value)
        {
            Value = value;
        }

        public void SetValue(Vector3Variable value)
        {
            Value = value.Value;
        }
    }
}
