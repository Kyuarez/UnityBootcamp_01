
public interface Observer
{
    public void OnNotify(EventType eventType, ObEventData eventData);    
}

/// <summary>
/// 옵저버에서 구분할 이벤트 타입
/// </summary>
public enum EventType
{
    HEALTH,
    ACHIEVEMENT,
    QUEST,
}

public enum HealthEventType
{
    HEAL,
    DAMAGE,
}

#region ObEventData
//옵저버의 매개변수 다변화를 위한 전용 데이터 클래스
public abstract class ObEventData { }

public class ObHealthEventData : ObEventData
{
    public float Hp { get; }
    public HealthEventType HealthEventType { get; }
    public ObHealthEventData(float _hp, HealthEventType healthEventType)
    {
        Hp = _hp;
        HealthEventType = healthEventType;
    }
}

public class ObAchievementEventData : ObEventData
{
    public bool IsCompleted { get; }
    public ObAchievementEventData(bool _isCompleted)
    {
        IsCompleted = _isCompleted;
    }
}
#endregion
