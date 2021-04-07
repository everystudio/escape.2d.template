using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class EventItemDataListener : ScriptableEventListener<ItemData>
{
    [SerializeField]
    protected EventItemData eventObject;

    [SerializeField]
    protected UnityEventItemData eventAction;

    protected override ScriptableEvent<ItemData> ScriptableEvent
    {
        get
        {
            return eventObject;
        }
    }

    protected override UnityEvent<ItemData> Action
    {
        get
        {
            return eventAction;
        }
    }
}
