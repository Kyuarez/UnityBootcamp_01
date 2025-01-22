using UnityEngine;

/// <summary>
/// 큐브 회전 스크립트
/// </summary>
public class CubeRotate : MonoBehaviour
{
    #region 필기
    /* [자료형 모음]
    int : 정수형 (소수점 없는 숫자)
    float : 실수형
    bool : 논리형(Boolean)
    string : 문자열 형 (char[])
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
        //deltaTime : 전 프레임이 끝나기 전 까지의 시간 (즉, 곱하면 컴퓨터 별 성능 차이 보정)
    }
    #endregion

    #region Method

    #endregion

}
