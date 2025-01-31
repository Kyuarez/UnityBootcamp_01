using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CoTextCount : MonoBehaviour
{
    private Text text;
    private int count;

    private void Awake()
    {
        text = GameObject.Find("CountText").GetComponent<Text>();
        count = 0;
    }

    private void Start()
    {
        StartCoroutine(CoCountPlus());
    }


    IEnumerator CoCountPlus()
    {

        //Debug.Log("아아 마이크 테스트");
        //yield return new WaitForSeconds(1f);
        //Debug.Log("밥만 먹고 올게유");
        //yield return new WaitForSeconds(5f);
        //Debug.Log("일하자.");

        while(count <= 1000)
        {
            count++;
            text.text = $"{count.ToString("N0")}"; //NO : 숫자 세자리 간격으로 , 찍기
            yield return new WaitForSeconds(1f);
        }
    }
}
