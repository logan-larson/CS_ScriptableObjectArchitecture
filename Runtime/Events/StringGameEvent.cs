using UnityEngine;

namespace CaffeinatedStudios.ScriptableObjectArchitecture
{
    [CreateAssetMenu(fileName = "StringGameEvent", menuName = "Events/String Game Event")]
    public class StringGameEvent : GameEvent<string> { }
}
