using UnityEngine;

public enum BombType
{
    Blue,
    Gold,
    Green,
    Pink,
    Red,
}

/// <summary>
/// Bomb °´Ã¼
/// </summary>
[RequireComponent(typeof(SpriteRenderer))]
public class WinterBomb : MonoBehaviour
{
    [SerializeField] private BombType type;
    private SpriteRenderer _Renderer;

    public void InitBomb(BombType bombType, Sprite img)
    {
        type = bombType;
        _Renderer = GetComponent<SpriteRenderer>();
        _Renderer.sprite = img;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (true == other.CompareTag(Define.Tag_Floor))
        {
            Destroy(gameObject);
        }
    }
}


