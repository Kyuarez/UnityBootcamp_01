using TMPro;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI headerText;
    [SerializeField] private TextMeshProUGUI scoreText;

    public void InitScoreUI()
    {
        headerText.text = Define.UI_SCORE;
        scoreText.text = 0.ToString();
    }

    public void SetScoreUI(int score)
    {
        scoreText.text = score.ToString();
    }
}
