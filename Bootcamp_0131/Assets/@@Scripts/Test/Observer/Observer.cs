using UnityEngine;

public class Observer : MonoBehaviour, IObserver
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void OnNotify()
    {

    }
}

#region Test
public class ObserverHP : MonoBehaviour, IObserverHP
{
    public void UpdateHP(int hp)
    {

    }
}
#endregion
