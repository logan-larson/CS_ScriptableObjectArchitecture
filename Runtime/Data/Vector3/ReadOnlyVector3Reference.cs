using System;
using UnityEngine;

namespace CaffeinatedStudios.ScriptableObjectArchitecture
{

    [Serializable]
    public class ReadOnlyVector3Reference
    {
        public bool UseConstant = true;
        public Vector3 ConstantValue;
        public Vector3Variable Variable;

        public ReadOnlyVector3Reference()
        { }

        public ReadOnlyVector3Reference(Vector3 value)
        {
            UseConstant = true;
            ConstantValue = value;
        }

        public Vector3 Value
        {
            get { return UseConstant ? ConstantValue : Variable.Value; }
        }

        public static implicit operator Vector3(ReadOnlyVector3Reference reference)
        {
            return reference.Value;
        }

    }
}
