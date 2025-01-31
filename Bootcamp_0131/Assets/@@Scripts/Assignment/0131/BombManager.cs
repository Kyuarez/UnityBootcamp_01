using System;
using System.Collections;
using UnityEngine;

/// <summary>
/// BombManager : 그냥 생성해서 폭탄 터지게 할 것임.
/// </summary>
public class BombManager : MonoBehaviour
{
    [SerializeField] private int bombMaxCount = 10;
    [SerializeField] private float delay = 1f;
    [SerializeField] private Vector3 areaMin = new Vector3(-7f, 3f, 0f);
    [SerializeField] private Vector3 areaMax = new Vector3(7f, 4.5f, 0f);

    private GameObject bombPrefab;
    private Sprite bomb_Blue;
    private Sprite bomb_Gold;
    private Sprite bomb_Green;
    private Sprite bomb_Pink;
    private Sprite bomb_Red;

    public void InitializeBombManager()
    {
        bombPrefab = Resources.Load<GameObject>(Define.BombPrefab);
        bomb_Blue = Resources.Load<Sprite>(Define.BombSprite_Blue);
        bomb_Gold = Resources.Load<Sprite>(Define.BombSprite_Gold);
        bomb_Green = Resources.Load<Sprite>(Define.BombSprite_Green);
        bomb_Pink = Resources.Load<Sprite>(Define.BombSprite_Pink);
        bomb_Red = Resources.Load<Sprite>(Define.BombSprite_Red);
    }

    public void BombAction()
    {
        StartCoroutine(CoCreateBomb());
    }

    private void CreateBomb(Vector3 position)
    {
        WinterBomb bomb = Instantiate(bombPrefab, position, Quaternion.identity, transform).GetComponent<WinterBomb>();
        bomb.gameObject.SetActive(false);
        BombType bombType = GetRandomBombType();
        bomb.InitBomb(bombType, GetBombImageByType(bombType));
        bomb.gameObject.SetActive(true);
    }

    private BombType GetRandomBombType()
    {
        Array values = Enum.GetValues(typeof(BombType)); 
        System.Random random = new System.Random(); 
        return (BombType)values.GetValue(random.Next(values.Length)); 
    }

    private Sprite GetBombImageByType(BombType bombType)
    {
        switch (bombType)
        {
            case BombType.Blue:
                return bomb_Blue;
            case BombType.Gold:
                return bomb_Gold;
            case BombType.Green:
                return bomb_Green;
            case BombType.Pink:
                return bomb_Pink;
            case BombType.Red:
                return bomb_Red;
            default:
                return null;
        }
    }

    IEnumerator CoCreateBomb()
    {
        for (int i = 0; i < bombMaxCount; i++)
        {
            Vector3 pos = new Vector3(UnityEngine.Random.Range(areaMin.x, areaMax.x),
                UnityEngine.Random.Range(areaMin.y, areaMax.y));
            CreateBomb(pos);
            yield return new WaitForSeconds(delay);
        }
    }
}
