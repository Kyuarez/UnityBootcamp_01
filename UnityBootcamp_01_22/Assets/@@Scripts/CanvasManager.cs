using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    //�׳� �ٷ� ã�� ���� (���߿� ui ����)
    public static ScoreCanvasController _ScoreCanvasController;

    private void Awake()
    {
        _ScoreCanvasController = GetComponentInChildren<ScoreCanvasController>();
    }
}
