using System;
using UnityEngine;

[CreateAssetMenu(fileName = "TimeSpanVariable", menuName = "Variables/Time Span Variable")]
public class TimeSpanVariable : ScriptableObject
{
#if UNITY_EDITOR
    [Multiline]
    public string DeveloperDescription = "";
#endif

    public TimeSpan Value;

    public void SetValue(TimeSpan value)
    {
        Value = value;
    }

    public void SetValue(TimeSpanVariable value)
    {
        Value = value.Value;
    }
}
