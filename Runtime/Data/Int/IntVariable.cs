using UnityEngine;

namespace CaffeinatedStudios.ScriptableObjectArchitecture
{

    [CreateAssetMenu(fileName = "IntVariable", menuName = "Variables/Int Variable")]
    public class IntVariable : ScriptableObject
    {
#if UNITY_EDITOR
        [Multiline]
        public string DeveloperDescription = "";
#endif

        public int Value;

        public void SetValue(int value)
        {
            Value = value;
        }

        public void SetValue(IntVariable value)
        {
            Value = value.Value;
        }
    }
}
