using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class GameEventListenerBase : MonoBehaviour
{
    public abstract void OnEventRaised();
    public abstract void OnEnable();
    public abstract void OnDisable();
}

public class GameEventListener : GameEventListenerBase
{
    [Tooltip("Events to register with.")]
    public GameEvent Event;

    [Tooltip("Response to invoke when Event is raised.")]
    public UnityEvent Response;

    public override void OnEventRaised()
    {
        Response.Invoke();
    }

    public override void OnEnable()
    {
        if (Event == null) return;
        Event.RegisterListener(this);
    }

    public override void OnDisable()
    {
        if (Event == null) return;
        Event.UnregisterListener(this);
    }
}

public class GameEventListener<T> : GameEventListenerBase
{
    [Tooltip("Events to register with.")]
    public GameEvent<T> Event;

    [Tooltip("Response to invoke when Event is raised.")]
    public UnityEvent<T> Response;

    public override void OnEventRaised()
    {
        Debug.LogWarning("Event raised without data");
    }

    public void OnEventRaised(T item)
    {
        Response.Invoke(item);
    }

    public override void OnEnable()
    {
        Event.RegisterListener(this);
    }

    public override void OnDisable()
    {
        Event.UnregisterListener(this);
    }
}

