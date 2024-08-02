using UnityEngine;

namespace CaffeinatedStudios.ScriptableObjectArchitecture
{

    [CreateAssetMenu(fileName = "BoolVariable", menuName = "Variables/Bool Variable")]
    public class BoolVariable : ScriptableObject
    {
#if UNITY_EDITOR
        [Multiline]
        public string DeveloperDescription = "";
#endif

        public bool Value;

        public void SetValue(bool value)
        {
            Value = value;
        }

        public void SetValue(BoolVariable value)
        {
            Value = value.Value;
        }
    }
}
