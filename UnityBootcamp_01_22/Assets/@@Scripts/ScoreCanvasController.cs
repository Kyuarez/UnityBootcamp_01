using TMPro;
using UnityEngine;

public class ScoreCanvasController : MonoBehaviour
{
    public TextMeshProUGUI scoreHeader;
    public TextMeshProUGUI scoreText;

    private void Start()
    {
        ResetScore();
    }

    public void ResetScore()
    {
        scoreText.text = "0";
    }

    public void SetScore(int point)
    {
        scoreText.text = $"{point}";
    }
}
