using UnityEngine;

public class VectorSample : MonoBehaviour
{
    //Vector3 vec = new Vector3();

    Vector3 a = new Vector3(2,3,0);
    Vector3 b = new Vector3(1,1,0);

    Vector3 Asite = new Vector3(10,1,0);
    Vector3 Bsite = new Vector3(5,3,0);

    private void Start()
    {
        //���� : �̵� ����       
        Vector3 c = a + b;
        //���� : �Ÿ� �� ���� ���ϱ�
        Vector3 d = a - b;
        float distance = Mathf.Abs((Asite - Bsite).magnitude);
        //���� & ������ : ���� ũ�� ���� (���� ����)
        Vector3 e = a * 3;
        e = e / 3;
        //����
        float dot = Vector3.Dot(a,b);
        //����
        Vector3 cross = Vector3.Cross(a,b);
        //ũ�� (����)
        float mag = a.magnitude;

    }
}
