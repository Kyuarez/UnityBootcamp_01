using UnityEngine;
using UnityEngine.UI;

public class HPBarUI : MonoBehaviour, Observer
{
    Slider hpBar;

    void Start()
    {
        hpBar = GetComponent<Slider>();

        ObserverManager.Instance.RegisterObserver(EventType.HEALTH, this);
    }

    void Update()
    {
        
    }

    public void OnNotify(EventType eventType, ObEventData eventData)
    {

    }
}
