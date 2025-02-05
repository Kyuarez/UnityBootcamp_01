using UnityEngine;

//@TK : юс╫ц
public class UIManager : MonoBehaviour
{
    private static UIManager _instance;
    public static UIManager UI_Manager 
    {  
        get { return _instance; }
    }

    public TimeUI UI_Time { get; private set; }
    public ScoreUI UI_Score { get; private set; }
    public ChillModeUI UI_ChillMode {  get; private set; }

    private void Awake()
    {
        if(_instance == null)
        {
            _instance = this;
        }

        UI_Time = GetComponentInChildren<TimeUI>();
        UI_Score = GetComponentInChildren<ScoreUI>();
        UI_ChillMode = GetComponentInChildren<ChillModeUI>();

        InitUI();
    }

    private void InitUI()
    {
        UI_Time.InitTimeUI();
        UI_Score.InitScoreUI();
        UI_ChillMode.InitChillModeUI();
    }

    public void SetScoreUI(int score) 
    {
        UI_Score.SetScoreUI(score);
    }

    public void OnChillModeUI() 
    {
        UI_ChillMode.OnChillMode(
            () => 
                {
                    AssignmentManager.Instance.IsChillMode = false;
                }
            );
    }
}
