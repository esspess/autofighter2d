using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Scriptable Objects/Game Event")]
public class GameEvent : ScriptableObject
{
    // for this event we want a list of listeners that will be notified when the event is raised
    private readonly List<GameEventListener> listeners = new List<GameEventListener>();

    // Add a listener to the list
    public void RegisterListener(GameEventListener listener)
    {
        if (!listeners.Contains(listener))
            listeners.Add(listener);
    }
    public void UnregisterListener(GameEventListener listener)
    {
        if (listeners.Contains(listener))
            listeners.Remove(listener);
    }
    // Raise the event and notify all listeners
    public void Raise()
    {
        // notify all listeners that the event has been raised
        for (int i = listeners.Count - 1; i >= 0; i--)
        {
            listeners[i].OnEventRaised();
        }
    }
}