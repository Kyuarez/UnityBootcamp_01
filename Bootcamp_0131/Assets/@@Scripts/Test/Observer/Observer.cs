/*
 2025.02.03
강사님 팁 : 매개변수 별도 클래스 만들어도 되고(mine), 아니면 object 타입으로 받거나, T(제너릭 사용하세요)
 */
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
