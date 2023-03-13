using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// An abstract class for creating events that can be subscribed to and raised.
/// This class inherits from Unity's ScriptableObject class and provides a generic implementation for
/// raising events that can be used by derived classes. The generic type parameter T represents
/// the type of data that is passed to the event handlers when the event is raised.
/// </summary>
/// <typeparam name="T">The type of data that is passed to the event handlers when the event is raised.</typeparam>

public abstract class BaseEvent <T> : ScriptableObject
{
    /// <summary>
    /// The event that will be raised when the RaiseEvent method is called. This is a UnityAction delegate that takes a single argument of type T.
    /// </summary>
    public UnityAction<T> OnEventRaised;

    /// <summary>
    /// Raises the event and passes the specified parameter to any subscribed event handlers. If there are no subscribed event handlers, this method does nothing.
    /// </summary>
    /// <param name="param">The parameter to pass to the event handlers.</param>
    public void RaiseEvent(T param)
    {
        OnEventRaised?.Invoke(param);
    }
}
