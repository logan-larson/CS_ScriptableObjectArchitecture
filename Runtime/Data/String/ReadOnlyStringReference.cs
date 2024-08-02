using System;
using UnityEngine;

namespace CaffeinatedStudios.ScriptableObjectArchitecture
{

    [Serializable]
    public class ReadOnlyStringReference
    {
        public bool UseConstant = true;
        public string ConstantValue;
        public StringVariable Variable;

        public ReadOnlyStringReference()
        { }

        public ReadOnlyStringReference(string value)
        {
            UseConstant = true;
            ConstantValue = value;
        }

        public string Value
        {
            get { return UseConstant ? ConstantValue : Variable.Value; }
        }

        public static implicit operator string(ReadOnlyStringReference reference)
        {
            return reference.Value;
        }

    }
}
