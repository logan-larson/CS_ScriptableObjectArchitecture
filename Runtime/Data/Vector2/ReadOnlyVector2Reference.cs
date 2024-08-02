using System;
using UnityEngine;

namespace CaffeinatedStudios.ScriptableObjectArchitecture
{

    [Serializable]
    public class ReadOnlyVector2Reference
    {
        public bool UseConstant = true;
        public Vector2 ConstantValue;
        public Vector2Variable Variable;

        public ReadOnlyVector2Reference()
        { }

        public ReadOnlyVector2Reference(Vector2 value)
        {
            UseConstant = true;
            ConstantValue = value;
        }

        public Vector2 Value
        {
            get { return UseConstant ? ConstantValue : Variable.Value; }
        }

        public static implicit operator Vector2(ReadOnlyVector2Reference reference)
        {
            return reference.Value;
        }

    }
}
