using TMPro;
using System;
using UnityEngine;


/// <summary>
/// GameTimeManage에서 정보 가져와서 UI 반영
/// </summary>
public class TimeUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI headerText;
    [SerializeField] private TextMeshProUGUI timeText;

    void Update()
    {
        SetTimeText();
    }

    public void InitTimeUI()
    {
        headerText.text = Define.UI_REALTIME;
        SetTimeText();
    }

    private void SetTimeText()
    {
        DateTime now = DateTime.Now;
        string timeStr = $"{now.Hour}시 {now.Minute}분 {now.Second}초.";
        timeText.text = timeStr;
    }
}
