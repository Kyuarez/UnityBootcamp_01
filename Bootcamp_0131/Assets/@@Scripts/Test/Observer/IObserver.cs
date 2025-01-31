
public interface IObserver
{
    public void OnNotify();
}

#region Test
public interface IObserverHP
{
    public void UpdateHP(int hp);
}
#endregion