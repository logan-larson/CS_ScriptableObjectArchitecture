using UnityEngine;

namespace CaffeinatedStudios.ScriptableObjectArchitecture
{

    [CreateAssetMenu(fileName = "FloatVariable", menuName = "Variables/Float Variable")]
    public class FloatVariable : ScriptableObject
    {
#if UNITY_EDITOR
        [Multiline]
        public string DeveloperDescription = "";
#endif

        public float Value;

        public void SetValue(float value)
        {
            Value = value;
        }

        public void SetValue(FloatVariable value)
        {
            Value = value.Value;
        }
    }
}
