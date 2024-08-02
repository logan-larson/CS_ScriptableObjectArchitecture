using System;

namespace CaffeinatedStudios.ScriptableObjectArchitecture
{
    [Serializable]
    public class BoolReference : ReadOnlyBoolReference
    {
        public BoolReference()
        { }

        public BoolReference(bool value)
        {
            UseConstant = true;
            ConstantValue = value;
        }

        public new bool Value
        {
            get { return UseConstant ? ConstantValue : Variable.Value; }
            set
            {
                if (UseConstant)
                    ConstantValue = value;
                else
                    Variable.Value = value;
            }
        }

        public static implicit operator bool(BoolReference reference)
        {
            return reference.Value;
        }
    }
}
