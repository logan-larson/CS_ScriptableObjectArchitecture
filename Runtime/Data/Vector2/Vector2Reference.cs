using System;
using UnityEngine;

namespace CaffeinatedStudios.ScriptableObjectArchitecture
{

    [Serializable]
    public class Vector2Reference : ReadOnlyVector2Reference
    {
        public Vector2Reference()
        { }

        public Vector2Reference(Vector2 value)
        {
            UseConstant = true;
            ConstantValue = value;
        }

        public new Vector2 Value
        {
            get { return UseConstant ? ConstantValue : Variable.Value; }
            set
            {
                if (UseConstant)
                    ConstantValue = value;
                else
                    Variable.SetValue(value);
            }
        }

        public static implicit operator Vector2(Vector2Reference reference)
        {
            return reference.Value;
        }

    }
}
