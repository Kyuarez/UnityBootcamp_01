using UnityEngine;
using TMPro;

public class StatsUI : MonoBehaviour, Observer
{
    public TextMeshProUGUI text;

    void Start()
    {
        ObserverManager.Instance.RegisterObserver(EventType.HEALTH, this);
    }

    void Update()
    {
        
    }

    public void OnNotify(EventType eventType, ObEventData eventData)
    {

    }
}
