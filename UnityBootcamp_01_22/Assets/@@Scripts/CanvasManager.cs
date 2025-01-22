using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    //그냥 바로 찾기 쉽게 (나중에 ui 구조)
    public static ScoreCanvasController _ScoreCanvasController;

    private void Awake()
    {
        _ScoreCanvasController = GetComponentInChildren<ScoreCanvasController>();
    }
}
