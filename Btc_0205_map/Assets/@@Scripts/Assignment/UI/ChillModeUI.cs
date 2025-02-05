using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ChillModeUI : MonoBehaviour
{
    [SerializeField] private Image chillImage;
    [SerializeField] private TextMeshProUGUI chillText;
    [SerializeField] private float fadeDuration = 5f;
    [SerializeField] private float fadeWaitTime = 10f;

    void Update()
    {
        
    }

    /// <summary>
    /// 처음 시작, chill mode off
    /// </summary>
    public void InitChillModeUI()
    {
        chillImage.enabled = false;
        chillImage.color = new Color(1, 1, 1, 0);

        chillText.text = Define.UI_CHILLTEXT;
        chillText.color = new Color(0, 0, 0, 0);
    }

    public void OnChillMode(UnityAction action)
    {
        StartCoroutine(CoChillMode(action));
    }

    IEnumerator CoChillMode(UnityAction action)
    {
        chillImage.enabled = true;
        //시작 Fade
        yield return StartCoroutine(CoFadeIn());
        yield return new WaitForSeconds(fadeWaitTime);
        yield return StartCoroutine(CoFadeOut());
        chillImage.enabled = false;
        action?.Invoke();
    }

    IEnumerator CoFadeIn()
    {
        float elapsedTime = 0f;
        while (elapsedTime < fadeDuration) 
        {
            elapsedTime += Time.deltaTime;
            float alpha = Mathf.Lerp(0f, 1f, elapsedTime / fadeDuration);
            Color color = new Color(0f, 0f, 0f, alpha);
            chillImage.color = color;
            chillText.color = color;
        }
        chillImage.color = new Color(1f, 1f, 1f, 1f);
        chillText.color = new Color(0f, 0f, 0f, 1f);
        yield return null;
    }

    IEnumerator CoFadeOut()
    {
        float elapsedTime = 0f;
        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            float alpha = Mathf.Lerp(1f, 0f, elapsedTime / fadeDuration);
            Color color = new Color(0f, 0f, 0f, alpha);
            chillImage.color = color;
            chillText.color = color;
        }
        chillImage.color = new Color(1f, 1f, 1f, 0f);
        chillText.color = new Color(0f, 0f, 0f, 0f);
        yield return null;
    }


}
