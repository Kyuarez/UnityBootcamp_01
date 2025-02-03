using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    Button btn_lerp;
    Button btn_moveToward;
    Button btn_slerp;
    Button btn_damage;
    Button btn_heal;

    private void Awake()
    {
        btn_lerp = GameObject.Find("Btn_Lerp").GetComponent<Button>();
        btn_moveToward = GameObject.Find("Btn_MoveTowards").GetComponent<Button>();
        btn_slerp = GameObject.Find("Btn_Slerp").GetComponent<Button>();
        btn_damage = GameObject.Find("Btn_Damage").GetComponent<Button>();
        btn_heal = GameObject.Find("Btn_Heal").GetComponent<Button>();


        btn_lerp.onClick.AddListener(() => OnClickMoveChange(MoveType.Lerp));
        btn_moveToward.onClick.AddListener(() => OnClickMoveChange(MoveType.MoveTowards));
        btn_slerp.onClick.AddListener(() => OnClickMoveChange(MoveType.Slerp));
        btn_damage.onClick.AddListener(() => OnClickDamage());
        btn_heal.onClick.AddListener(() => OnClickHeal());
    }

    #region OnClick
    public void OnClickMoveChange(MoveType moveType)
    {
        TestManager.Instance.CircleData.ChangeMoveType(moveType);
    }

    public void OnClickDamage()
    {
        //Temp코드
        ObHealthEventData obHealthEventData = new ObHealthEventData(-10f,HealthEventType.DAMAGE);
        ObserverManager.Instance.OnNotify(EventType.HEALTH, obHealthEventData);
    }

    public void OnClickHeal()
    {
        //Temp코드
        ObHealthEventData obHealthEventData = new ObHealthEventData(10f, HealthEventType.HEAL);
        ObserverManager.Instance.OnNotify(EventType.HEALTH, obHealthEventData);
    }
    #endregion
}
