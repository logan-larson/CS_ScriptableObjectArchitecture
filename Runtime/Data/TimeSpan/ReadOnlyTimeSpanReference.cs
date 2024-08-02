using System;

namespace CaffeinatedStudios.ScriptableObjectArchitecture
{
    [Serializable]
    public class ReadOnlyTimeSpanReference
    {
        public bool UseConstant = true;
        public TimeSpan ConstantValue;
        public TimeSpanVariable Variable;

        public ReadOnlyTimeSpanReference()
        { }

        public ReadOnlyTimeSpanReference(TimeSpan value)
        {
            UseConstant = true;
            ConstantValue = value;
        }

        public TimeSpan Value
        {
            get { return UseConstant ? ConstantValue : Variable.Value; }
        }

        public static implicit operator TimeSpan(ReadOnlyTimeSpanReference reference)
        {
            return reference.Value;
        }

    }
}
