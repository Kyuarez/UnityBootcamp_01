using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System;

/// <summary>
/// Title Manager
/// / ���� ���� ��, �ΰ� ���̵� �� �ƿ�
/// </summary>
public class TitleManager : MonoBehaviour
{
    public Image backgroundImg;
    public Image titleImg;

    public Image coverImg;
    public float duration = 3.0f; //fade in & out �� �ð� (���� ���� ����.)
    public float waitingTime = .0f; //�ΰ� �����ִ� �ð�

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
        //��� �ð�
        yield return new WaitForSeconds(waitingTime);
        //Last In
        yield return StartCoroutine(CoFadeIn(fadeDuration));
        //��� �ð�
        backgroundImg.enabled = false;
        titleImg.enabled = false;
        yield return new WaitForSeconds(waitingTime);
        //���� ����
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
