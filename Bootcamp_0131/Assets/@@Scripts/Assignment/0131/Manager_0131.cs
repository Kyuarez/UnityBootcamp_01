using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 01.31. ���� ���� �Ŵ���
/// -> Title Fade ȣ��,
/// -> �ް� ��ź ���� ���� ��ô
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
/// ���ӿ� �� ������Ʈ �� ���� Ŭ����
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
