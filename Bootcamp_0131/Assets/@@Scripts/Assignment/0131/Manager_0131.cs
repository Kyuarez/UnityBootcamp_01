using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 01.31. 과제 전용 매니저
/// -> Title Fade 호출,
/// -> 달걀 폭탄 랜덤 생성 투척
/// </summary>
public class Manager_0131 : MonoBehaviour
{
    private TitleManager titleManager;
    private BombManager bombManager;

    private void Awake()
    {
        Bind();
    }

    private void Bind()
    {
        titleManager = GameObject.Find(Define.TitleManager).GetComponent<TitleManager>();
        titleManager.InitializeTitle();
        bombManager = GetComponentInChildren<BombManager>();
        bombManager.InitializeBombManager();
    }

    private void Start()
    {
        titleManager.TitleAction(bombManager.BombAction);
    }
}

/// <summary>
/// 게임에 들어갈 오브젝트 등 정의 클래스
/// </summary>
public class Define
{
    public readonly static string TitleManager = "@@TitleManager";

    public readonly static string BombPrefab = "Prefabs/WinterBomb";
    public readonly static string BombSprite_Blue = "Sprites/Bomb/floralBlue";
    public readonly static string BombSprite_Gold = "Sprites/Bomb/floralGold";
    public readonly static string BombSprite_Green = "Sprites/Bomb/floralGreen";
    public readonly static string BombSprite_Pink = "Sprites/Bomb/floralPink";
    public readonly static string BombSprite_Red = "Sprites/Bomb/floralRed";

    public readonly static string Tag_Floor = "Floor";

}
