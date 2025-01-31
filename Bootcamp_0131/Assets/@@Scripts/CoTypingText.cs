using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 미션 : Queue로 만드세요
 */
public class CoTypingText : MonoBehaviour
{
    [SerializeField]private float delay = 0.2f;
    [SerializeField][TextArea] private string content;

    [SerializeField][TextArea] private List<string> contents;



    private Text _text;
    private Button btn_Talk;
    private Button btn_multiply2;

    private int currentText;

    private void Awake()
    {
        _text = GameObject.Find("TypingText").GetComponent<Text>();
        currentText = 0;
    }

    void Start()
    {
        //StartCoroutine("TypingText");
    }


    public void ByTwo()
    {
        if(delay == 0.2f)
        {
            delay = 0.1f;
        }
        else
        {
            delay = 0.2f;
        }
    }

    public void OnClickTalk()
    {
        StopAllCoroutines();
        _text.text = "";

        string message = contents[currentText];
        StartCoroutine(TypingCo(message));

        currentText++;
        if (currentText > contents.Count - 1)
        {
            currentText = 0;
        }
    }

    
    public IEnumerator TypingText()
    {
        _text.text = "";
        int typingCount = 0;
        while (typingCount < content.Length) 
        {
            _text.text += content[typingCount].ToString();
            typingCount++;
            yield return new WaitForSeconds(delay);
        }
        
        yield return null;
    }

    public IEnumerator TypingCo(string text)
    {
        int typingCount = 0;
        while (typingCount < text.Length)
        {
            _text.text += text[typingCount].ToString();
            typingCount++;
            yield return new WaitForSeconds(delay);
        }
    }

    

}
