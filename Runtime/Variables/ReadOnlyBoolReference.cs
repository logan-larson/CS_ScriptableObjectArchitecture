using System;
using UnityEngine;

namespace CaffeinatedStudios.ScriptableObjectArchitecture
{

    [Serializable]
    public class ReadOnlyBoolReference
    {
        public bool UseConstant = true;
        public bool ConstantValue;
        public BoolVariable Variable;

        public ReadOnlyBoolReference()
        { }

        public ReadOnlyBoolReference(bool value)
        {
            UseConstant = true;
            ConstantValue = value;
        }

        public bool Value
        {
            get { return UseConstant ? ConstantValue : Variable.Value; }
        }

        public static implicit operator bool(ReadOnlyBoolReference reference)
        {
            return reference.Value;
        }

    }
}
