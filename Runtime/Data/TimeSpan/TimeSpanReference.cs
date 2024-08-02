using System;

namespace CaffeinatedStudios.ScriptableObjectArchitecture
{
    [Serializable]
    public class TimeSpanReference : ReadOnlyTimeSpanReference
    {
        public TimeSpanReference()
        { }

        public TimeSpanReference(TimeSpan value)
        {
            UseConstant = true;
            ConstantValue = value;
        }

        public new TimeSpan Value
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

        public static implicit operator TimeSpan(TimeSpanReference reference)
        {
            return reference.Value;
        }
    }
}
