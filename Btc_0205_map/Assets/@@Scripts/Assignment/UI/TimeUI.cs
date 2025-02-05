using TMPro;
using System;
using UnityEngine;


/// <summary>
/// GameTimeManage���� ���� �����ͼ� UI �ݿ�
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
        string timeStr = $"{now.Hour}�� {now.Minute}�� {now.Second}��.";
        timeText.text = timeStr;
    }
}
