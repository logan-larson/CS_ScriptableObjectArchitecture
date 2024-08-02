using System;
using UnityEngine;

namespace CaffeinatedStudios.ScriptableObjectArchitecture
{

    [Serializable]
    public class ReadOnlyFloatReference
    {
        public bool UseConstant = true;
        public float ConstantValue;
        public FloatVariable Variable;

        public ReadOnlyFloatReference()
        { }

        public ReadOnlyFloatReference(float value)
        {
            UseConstant = true;
            ConstantValue = value;
        }

        public float Value
        {
            get { return UseConstant ? ConstantValue : Variable.Value; }
        }

        public static implicit operator float(ReadOnlyFloatReference reference)
        {
            return reference.Value;
        }

    }
}
