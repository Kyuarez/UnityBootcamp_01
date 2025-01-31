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
        //덧셈 : 이동 로직       
        Vector3 c = a + b;
        //뺄셈 : 거리 및 방향 구하기
        Vector3 d = a - b;
        float distance = Mathf.Abs((Asite - Bsite).magnitude);
        //곱셈 & 나눗셈 : 벡터 크기 변경 (방향 유지)
        Vector3 e = a * 3;
        e = e / 3;
        //내적
        float dot = Vector3.Dot(a,b);
        //외적
        Vector3 cross = Vector3.Cross(a,b);
        //크기 (길이)
        float mag = a.magnitude;

    }
}
