using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// ������ ���� ����ϱ� ���� �ӽ� �Ŵ���
/// </summary>
public class TestManager : MonoBehaviour
{
    private static TestManager _instance;
    public static TestManager Instance { get { return _instance; } }

    private CircleMove circleData;
    public CircleMove CircleData {  get { return circleData; } }

    private void Awake()
    {
        if(_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        circleData = gameObject.GetComponent<CircleMove>();
    }
}
