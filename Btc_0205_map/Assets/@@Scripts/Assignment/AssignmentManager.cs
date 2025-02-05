using System.Runtime.Serialization;
using UnityEngine;

/// <summary>
/// 과제(25.02.05) 전용 게임매니저
/// </summary>
public class AssignmentManager : MonoBehaviour
{
    #region Singleton
    private static AssignmentManager _instance;

    public static AssignmentManager Instance
    {
        get
        {
            return _instance;
        }
    }

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    #endregion

    [SerializeField] private int score = 0;
    
    private bool isChillMode = false;
    private ObjectGenerator objectGenerator;

    private Material defaultSkymat;
    private Material chillSkymat;

    public bool IsChillMode { 
        get  
        { 
            return isChillMode; 
        }
        set
        {
            if(value == false)
            {
                isChillMode = value;
                RenderSettings.skybox = defaultSkymat;
                ResetScore();
            }
        }
    }

    private void Start()
    {
        objectGenerator = GameObject.Find("@@ObjectGenerator").GetComponent<ObjectGenerator>();
        defaultSkymat = Resources.Load<Material>(Define.RES_SKY_DEFAULT);
        chillSkymat = Resources.Load<Material>(Define.RES_SKY_CHILL);

        RenderSettings.skybox = defaultSkymat;

        InitGameData();
    }

    private void Update()
    {
        if(score >= 10 && isChillMode == false)
        {
            isChillMode = true;
            RenderSettings.skybox = chillSkymat;
            UIManager.UI_Manager.OnChillModeUI();
        }


        //chillmode일 땐 쏘지 못하게
        if (true == Input.GetMouseButtonDown(0) && IsChillMode == false)
        {
            objectGenerator.CreateObject();
        }
    }

    private void InitGameData()
    {
        score = 0;
        isChillMode = false;
    }

    private void ResetScore()
    {
        score = 0;
        UIManager.UI_Manager.SetScoreUI(score);
    }

    public void AddScore()
    {
        score++;
        UIManager.UI_Manager.SetScoreUI(score);
    }



}
