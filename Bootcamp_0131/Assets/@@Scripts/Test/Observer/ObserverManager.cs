using System.Collections.Generic;
using UnityEngine;

public class ObserverManager : MonoBehaviour
{
    #region Singletone
    private static ObserverManager _instance;
    public static ObserverManager Instance
    {
        get
        {
            if (_instance == null)
            {
                GameObject obj = new GameObject("@@ObserverManager");
                _instance = obj.AddComponent<ObserverManager>();
            }
            return _instance;
        }
    }
    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        observers = new Dictionary<EventType, List<Observer>>();
    }
    #endregion

    public void RegisterObserver(EventType eventType, Observer observer)
    {
        if(false == observers.ContainsKey(eventType))
        {
            observers.Add(eventType, new List<Observer>());
        }

        observers[eventType].Add(observer);
    }

    public void UnregisterObserver(EventType eventType, Observer observer)
    {
        observers[eventType].Remove(observer);
    }

    #region OnNotify
    public void OnNotify(EventType eventType, ObEventData eventData)
    {
        if(false == observers.ContainsKey(eventType))
        {
            return;
        }

        foreach (Observer _observer in observers[eventType])
        {
            _observer.OnNotify(eventType, eventData);
        }
    }
    #endregion

    Dictionary<EventType, List<Observer>> observers;
}
