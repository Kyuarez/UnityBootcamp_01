using UnityEngine;

/// <summary>
/// 유니티 어트리뷰트(Unity Attribute)
/// 유니티에서 에디터에 맞게 스크립트를 커스텀하는 것이 가능.
/// </summary>

[AddComponentMenu("CustomUtility/ScriptExample")]
public class ScriptExample : MonoBehaviour
{
    [Range(1, 99)] public int level;
    [Range(0, 100)] public int volume;

    [Header("플레이어 이름")] public string _name;

    [TextArea] public string talk01;
    [TextArea(1, 5)] public string talk02;
    [TextArea(5, 7)] public string talk03;

    [Tooltip("플레이어 사망 여부")] public bool isDead;
    [Tooltip("플레이어 점프 중 체크")] public bool isJump;


    [ContextMenu("HelloEveryone")]
    void HelloEveryone()
    {
        Debug.Log("모두들 안녕");
    }

    void HelloSomeone(string name)
    {

    }

}
