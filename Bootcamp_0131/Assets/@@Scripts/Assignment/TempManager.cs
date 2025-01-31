using System.Collections;
using UnityEngine;
using UnityEngine.UIElements;

/* [�ó�����]
 1. �����ϸ� ��ź ���� �� �Ͷ߸���
 2. ������ ���̵� �ƿ�
 */
public class TempManager : MonoBehaviour
{
    private GameObject bomb;
    private Sprite bombImg;
    private Sprite bomb2Img;

    private BackgroundManager backgroundManager;

    private void Awake()
    {
        bomb = Resources.Load<GameObject>("Prefabs/Bomb");
        bombImg = Resources.Load<Sprite>("Sprites/Bomb01");
        bomb2Img = Resources.Load<Sprite>("Sprites/Bomb02");

        backgroundManager = GameObject.Find("BackgroundManger").GetComponent<BackgroundManager>();
    }

    void Start()
    {
        StartCoroutine(InstantiateBomb());
    }

    void Update()
    {
        
    }

    private IEnumerator InstantiateBomb()
    {
        GameObject prefab = Instantiate(bomb);
        Bomb b = prefab.GetComponent<Bomb>();
        b.DoBomb(4, bombImg, bomb2Img);
        yield return new WaitForSeconds(4f);
        backgroundManager.FadeInOut();
    }
}
