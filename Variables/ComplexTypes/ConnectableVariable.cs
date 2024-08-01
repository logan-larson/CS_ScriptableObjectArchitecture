using UnityEngine;

[CreateAssetMenu(fileName = "ConnectableVariable", menuName = "Variables/Complex/Connectable Variable")]
public class ConnectableVariable : ScriptableObject
{
#if UNITY_EDITOR
    [Multiline]
    public string DeveloperDescription = "";
#endif

    public Connectable Value;

    public void SetValue(Connectable value)
    {
        Value = value;
    }

    public void SetValue(ConnectableVariable value)
    {
        Value = value.Value;
    }
}
