using System;

namespace CaffeinatedStudios.ScriptableObjectArchitecture
{
    [Serializable]
    public class StringReference : ReadOnlyStringReference
    {
        public StringReference()
        { }

        public StringReference(string value)
        {
            UseConstant = true;
            ConstantValue = value;
        }

        public new string Value
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

        public static implicit operator string(StringReference reference)
        {
            return reference.Value;
        }

    }
}
