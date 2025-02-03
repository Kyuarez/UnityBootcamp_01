
public interface Observer
{
    public void OnNotify(EventType eventType, ObEventData eventData);    
}

/// <summary>
/// ���������� ������ �̺�Ʈ Ÿ��
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
//�������� �Ű����� �ٺ�ȭ�� ���� ���� ������ Ŭ����
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
