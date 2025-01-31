using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System;

/// <summary>
/// Title Manager
/// / 게임 시작 시, 로고 페이드 인 아웃
/// </summary>
public class TitleManager : MonoBehaviour
{
    public Image backgroundImg;
    public Image titleImg;

    public Image coverImg;
    public float duration = 3.0f; //fade in & out 총 시간 (절반 나눌 것임.)
    public float waitingTime = .0f; //로고 보여주는 시간

    public void InitializeTitle()
    {
        coverImg.color = new Color(0, 0, 0, 255);
    }

    public void TitleAction(Action bombAction = null)
    {
        StartCoroutine(CoFadeOutIn(bombAction));
    }

    IEnumerator CoFadeOutIn(Action bombAction = null)
    {
        float fadeDuration = duration / 2;
        //Out first 
        yield return StartCoroutine(CoFadeOut(fadeDuration));
        //대기 시간
        yield return new WaitForSeconds(waitingTime);
        //Last In
        yield return StartCoroutine(CoFadeIn(fadeDuration));
        //대기 시간
        backgroundImg.enabled = false;
        titleImg.enabled = false;
        yield return new WaitForSeconds(waitingTime);
        //게임 시작
        yield return StartCoroutine(CoFadeOut(1f));
        //bomb Action
        bombAction?.Invoke();
    }

    IEnumerator CoFadeOut(float duration)
    {
        float elapsedTime = 0f;
        float alpha = 1f;
        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            alpha = Mathf.Lerp(1f, 0f, elapsedTime / duration);
            coverImg.color = new Color(0, 0, 0, alpha);
            yield return null;
        }
    }

    IEnumerator CoFadeIn(float duration)
    {
        float elapsedTime = 0f;
        float alpha = 0f;
        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            alpha = Mathf.Lerp(0f, 1f, elapsedTime / duration);
            coverImg.color = new Color(0, 0, 0, alpha);
            yield return null;
        }
    }
}
