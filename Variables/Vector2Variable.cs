using UnityEngine;

[CreateAssetMenu(fileName = "Vector2Variable", menuName = "Variables/Vector2 Variable")]
public class Vector2Variable : ScriptableObject
{
#if UNITY_EDITOR
    [Multiline]
    public string DeveloperDescription = "";
#endif

    public Vector2 Value;

    public void SetValue(Vector2 value)
    {
        Value = value;
    }

    public void SetValue(Vector2Variable value)
    {
        Value = value.Value;
    }
}
