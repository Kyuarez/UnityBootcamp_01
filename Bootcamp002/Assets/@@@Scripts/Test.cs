using UnityEngine;
// using�� ������ ���� ���� �ڵ忡�� ����ϴ� ���Դϴ� ��� ���Դϴ�. 

//namespace UnityTutorial
//{
//    public class SampleA
//    {

//    }
//}

//public class SampleA
//{

//}

/// <summary>
/// ó������ ���� ����Ƽ�� Ŭ����
/// </summary>
public class Test : MonoBehaviour //MonoBehaviour
{
    private int count = 0;
    void Start()
    {

    }

    void Update()
    {
        Debug.Log($"{count} �¿� �ݺ� �ٱ�");
        count++;
    }
}