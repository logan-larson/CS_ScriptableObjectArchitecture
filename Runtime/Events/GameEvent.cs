using UnityEngine;
using System.Collections.Generic;

namespace CaffeinatedStudios.ScriptableObjectArchitecture
{
    public abstract class GameEventBase : ScriptableObject
    {
        private readonly List<GameEventListenerBase> _eventListeners = new List<GameEventListenerBase>();

        public void Raise()
        {
            for (int i = _eventListeners.Count - 1; i >= 0; i--)
            {
                _eventListeners[i].OnEventRaised();
            }
        }

        public void RegisterListener(GameEventListenerBase listener)
        {
            if (!_eventListeners.Contains(listener))
            {
                _eventListeners.Add(listener);
            }
        }

        public void UnregisterListener(GameEventListenerBase listener)
        {
            if (_eventListeners.Contains(listener))
            {
                _eventListeners.Remove(listener);
            }
        }
    }

    [CreateAssetMenu(fileName = "GameEventBase", menuName = "Events/Game Event Base")]
    public class GameEvent : GameEventBase { }

    public abstract class GameEvent<T> : GameEventBase
    {
        private readonly List<GameEventListener<T>> _eventListeners = new List<GameEventListener<T>>();

        public void Raise(T item)
        {
            for (int i = _eventListeners.Count - 1; i >= 0; i--)
            {
                _eventListeners[i].OnEventRaised(item);
            }
        }

        public void RegisterListener(GameEventListener<T> listener)
        {
            if (!_eventListeners.Contains(listener))
            {
                _eventListeners.Add(listener);
            }
        }

        public void UnregisterListener(GameEventListener<T> listener)
        {
            if (_eventListeners.Contains(listener))
            {
                _eventListeners.Remove(listener);
            }
        }
    }
}
