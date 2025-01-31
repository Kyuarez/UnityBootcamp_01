using System.Collections;
using UnityEngine;
using UnityEngine.UIElements;

/* [시나리오]
 1. 시작하면 폭탄 생성 후 터뜨리기
 2. 터지면 페이드 아웃
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
