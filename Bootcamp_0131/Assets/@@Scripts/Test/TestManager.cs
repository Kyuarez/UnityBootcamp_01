using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 옵저버 패턴 사용하기 위해 임시 매니저
/// </summary>
public class TestManager : MonoBehaviour
{
    CircleMove circleData;

    Button btn_lerp;
    Button btn_moveToward;
    Button btn_slerp;
    Button btn_damage;
    Button btn_heal;

    private void Awake()
    {
        circleData = gameObject.GetComponent<CircleMove>();

        #region TempCode
        btn_lerp = GameObject.Find("Btn_Lerp").GetComponent<Button>();
        btn_moveToward = GameObject.Find("Btn_MoveTowards").GetComponent<Button>();
        btn_slerp = GameObject.Find("Btn_Slerp").GetComponent<Button>();

        btn_lerp.onClick.AddListener(() => OnClickMoveChange(MoveType.Lerp));
        btn_moveToward.onClick.AddListener(() => OnClickMoveChange(MoveType.MoveTowards));
        btn_slerp.onClick.AddListener(() => OnClickMoveChange(MoveType.Slerp));
        #endregion

    }

    #region OnClick
    public void OnClickMoveChange(MoveType moveType)
    {
        circleData.ChangeMoveType(moveType);
    }

    public void OnClickHp(int value)
    {
        
    }
    #endregion
}
