using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Bomb : MonoBehaviour
{
    [SerializeField] private int count;
    private SpriteRenderer _renderer;
    

    public void DoBomb(int _count, Sprite bomb01, Sprite bomb02)
    {
        count = _count;
        _renderer = GetComponent<SpriteRenderer>();
        _renderer.sprite = bomb01;
        StartCoroutine(CoBomb(bomb02));
    }

    private IEnumerator CoBomb(Sprite bomb)
    {
        yield return new WaitForSeconds(count / 2);
        _renderer.sprite = bomb;
        yield return new WaitForSeconds(count / 2);
        Destroy(gameObject);
        yield return null;
    }
}
