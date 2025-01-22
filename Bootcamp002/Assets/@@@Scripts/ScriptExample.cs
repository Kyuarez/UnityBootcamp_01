using UnityEngine;

/// <summary>
/// ����Ƽ ��Ʈ����Ʈ(Unity Attribute)
/// ����Ƽ���� �����Ϳ� �°� ��ũ��Ʈ�� Ŀ�����ϴ� ���� ����.
/// </summary>

[AddComponentMenu("CustomUtility/ScriptExample")]
public class ScriptExample : MonoBehaviour
{
    [Range(1, 99)] public int level;
    [Range(0, 100)] public int volume;

    [Header("�÷��̾� �̸�")] public string _name;

    [TextArea] public string talk01;
    [TextArea(1, 5)] public string talk02;
    [TextArea(5, 7)] public string talk03;

    [Tooltip("�÷��̾� ��� ����")] public bool isDead;
    [Tooltip("�÷��̾� ���� �� üũ")] public bool isJump;


    [ContextMenu("HelloEveryone")]
    void HelloEveryone()
    {
        Debug.Log("��ε� �ȳ�");
    }

    void HelloSomeone(string name)
    {

    }

}
