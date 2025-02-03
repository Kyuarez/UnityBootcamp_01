using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class FaceUI : MonoBehaviour, Observer
{
    [SerializeField] private float duration = 0.2f;
    
    private Image faceImg;

    void Start()
    {
        faceImg = GetComponent<Image>();
        ObserverManager.Instance.RegisterObserver(EventType.HEALTH, this);
    }

    void Update()
    {
        
    }

    public void OnNotify(EventType eventType, ObEventData eventData)
    {
        if(eventData is not ObHealthEventData)
        {
            return;
        }
       
        ObHealthEventData obHealthEventData = eventData as ObHealthEventData;

        switch (obHealthEventData.HealthEventType)
        {
            case HealthEventType.HEAL:
                StopAllCoroutines();
                faceImg.color = C_DEFAULT;
                StartCoroutine(CoFaceColor(C_DEFAULT, C_HEAL));
                break;
            case HealthEventType.DAMAGE:
                StopAllCoroutines();
                faceImg.color = C_DEFAULT;
                StartCoroutine(CoFaceColor(C_DEFAULT, C_DAMAGE));
                break;
            default:
                break;
        }
    }

    IEnumerator CoFaceColor(Color32 origin, Color32 change)
    {
        float changeTime = duration / 2;
        float elapsedTime = 0;
        
        while (elapsedTime < changeTime) 
        {
            faceImg.color = Color.Lerp(origin, change, elapsedTime / changeTime);
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        faceImg.color = change;

        yield return new WaitForSeconds(duration);

        elapsedTime = 0;
        while (elapsedTime < changeTime)
        {
            faceImg.color = Color.Lerp(change, origin, elapsedTime / changeTime);
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        faceImg.color = C_DEFAULT;
    }


    private Color32 C_HEAL = new Color32(23, 255, 0, 255);
    private Color32 C_DAMAGE = new Color32(255, 0, 0, 255);
    private Color32 C_DEFAULT = new Color32(255, 255, 255, 255);
}
