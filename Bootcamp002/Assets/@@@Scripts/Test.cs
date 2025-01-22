using UnityEngine;
// using은 다음에 적힌 것을 코드에서 사용하는 중입니다 라는 뜻입니다. 

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
/// 처음으로 만들어본 유니티의 클래스
/// </summary>
public class Test : MonoBehaviour //MonoBehaviour
{
    private int count = 0;
    void Start()
    {

    }

    void Update()
    {
        Debug.Log($"{count} 좌우 반복 뛰기");
        count++;
    }
}