using UnityEngine;

/// <summary>
/// ť�� ȸ�� ��ũ��Ʈ
/// </summary>
public class CubeRotate : MonoBehaviour
{
    #region �ʱ�
    /* [�ڷ��� ����]
    int : ������ (�Ҽ��� ���� ����)
    float : �Ǽ���
    bool : ����(Boolean)
    string : ���ڿ� �� (char[])
     */
    #endregion

    #region Variable
    public float factorX = 500f;
    //private float hiddenFactorX;
    #endregion

    #region Unity Event
    void Start()
    {
        //hiddenFactorX = 10f;
    }

    void Update()
    {
        transform.Rotate(new Vector3(factorX * Time.deltaTime, 0f, 0f));
        //deltaTime : �� �������� ������ �� ������ �ð� (��, ���ϸ� ��ǻ�� �� ���� ���� ����)
    }
    #endregion

    #region Method

    #endregion

}
