using System;
using UnityEngine;

[Serializable]
public class ConnectableReference
{
    public bool UseConstant = true;
    public bool ConstantValue;
    public ConnectableVariable Variable;

    public ConnectableReference()
    { }

    public ConnectableReference(bool value)
    {
        UseConstant = true;
        ConstantValue = value;
    }

    public bool Value
    {
        get { return UseConstant ? ConstantValue : Variable.Value; }
    }
    
    public static implicit operator bool(ConnectableReference reference)
    {
        return reference.Value;
    }
    
}
