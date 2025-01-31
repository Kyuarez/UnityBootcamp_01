using System.Collections.Generic;
using UnityEngine;

public class Subject : MonoBehaviour
{
    private List<IObserver> observers = new List<IObserver>();

    public void Register(IObserver _observer)
    {
        observers.Add( _observer);
    }
    public void UnRegister(IObserver _observer)
    {
        observers.Remove(_observer);
    }
    public void Notify()
    {
        foreach (var observer in observers)
        {
            observer.OnNotify();
        }
    }

    public virtual void ChangeState()
    {
        //변화 관련 코드.
        Notify();
    }
}

#region Test
//Test Player
public class TestSubject : MonoBehaviour
{
    private List<IObserverHP> _observers = new List<IObserverHP>();
    private int hp;

    public TestSubject(int _hp)
    {
        hp = _hp;
    }

    public void Register(IObserverHP _observer)
    {
        _observers.Add( _observer);
    }
    public void UnRegister(IObserverHP _observer)
    {
        _observers.Remove(_observer);
    }
    public void UpdateHP()
    {
        foreach (var observer in _observers)
        {
            observer.UpdateHP(hp);
        }

    }

    public void ChangeHP(int value)
    {
        hp = Mathf.Clamp(hp + value, 0, 100);
        UpdateHP();
    }
} 
#endregion
