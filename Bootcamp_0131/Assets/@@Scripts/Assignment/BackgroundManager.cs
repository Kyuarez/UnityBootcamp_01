using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundManager : MonoBehaviour
{
    private Image backgroundImage;

    private float duration = 1.0f;

    private void Awake()
    {
        backgroundImage = GameObject.Find("BackgroundImage").GetComponent<Image>();
        Initialize();
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Initialize()
    {
        if (backgroundImage == null)
        {
            Debug.Assert(false, "배경이미지 null");
        }

        backgroundImage.color = new Color(0f, 0f, 0f, 0f);
    }

    public void FadeInOut()
    {
        StartCoroutine(CoFadeIn());
    }

    IEnumerator CoFadeIn()
    {
        float elapsedTime = 0f;
        float a = 0f;
        while (elapsedTime < duration)
        {
            a = Mathf.Clamp01(elapsedTime / duration);
            backgroundImage.color = new Color(0f, 0f, 0f, a);
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        backgroundImage.color = new Color(0f, 0f, 0f, 255);
    }
}
