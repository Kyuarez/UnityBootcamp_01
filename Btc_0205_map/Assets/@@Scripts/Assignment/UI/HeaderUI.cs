using TMPro;
using UnityEngine;

public class HeaderUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI headerText;

    private void Awake()
    {
        InitHederUI();
    }

    private void InitHederUI()
    {
        headerText.text = Define.UI_TITLE;
    }
}
