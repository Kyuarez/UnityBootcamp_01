using System;
using System.Collections;
using UnityEngine;

public class GameTimeManager : MonoBehaviour
{
    
    private static GameTimeManager _instance;

    public static GameTimeManager Instance
    {
        get
        {
            return _instance;
        }
    }

    private void Awake()
    {
        if(_instance != null)
        {
            Destroy(this);
        }
        else
        {
            _instance = this;
            DontDestroyOnLoad(this);
        }
    }

    [SerializeField] private CheckTimeType checkTimeType;

    void Start()
    {
        Initialize();
    }

    private void Initialize()
    {
        checkTimeType = CheckTimeType.INGAME;
    }

    //@TK : �׳� ���ѷ��� �ڷ�ƾ���� üũ����
    IEnumerator CoInGameTimeCheck()
    {
        yield return null;
    }
    IEnumerator CoRealTimeCheck()
    {
        yield return null;
    }
}
