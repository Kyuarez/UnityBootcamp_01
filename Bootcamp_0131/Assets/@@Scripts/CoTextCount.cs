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

        //Debug.Log("�ƾ� ����ũ �׽�Ʈ");
        //yield return new WaitForSeconds(1f);
        //Debug.Log("�丸 �԰� �ð���");
        //yield return new WaitForSeconds(5f);
        //Debug.Log("������.");

        while(count <= 1000)
        {
            count++;
            text.text = $"{count.ToString("N0")}"; //NO : ���� ���ڸ� �������� , ���
            yield return new WaitForSeconds(1f);
        }
    }
}
