using UnityEngine;

public class TKCameraController : MonoBehaviour
{
    [SerializeField] private float camSpeed = 2.5f;
    [SerializeField] private float fixY = 0f;
    [SerializeField] private float fixZ = -10f;

    float camWidth;
    float camHeight;

    private GameObject _target;
    private Camera cam;

    private float limitMinX;
    private float limitMinY;
    private float limitMaxX;
    private float limitMaxY;


    void Start()
    {
        cam = GetComponent<Camera>();
        _target = GameObject.Find("Circle").gameObject;
        camWidth = cam.aspect * cam.orthographicSize;
        camHeight = cam.orthographicSize;

        Sprite bg = GameObject.Find("BG").GetComponent<SpriteRenderer>().sprite;
        float sizeX = bg.bounds.size.x / 2;
        float sizeY = bg.bounds.size.y / 2;

        limitMinX = -sizeX;
        limitMinY = -sizeY;
        limitMaxX = sizeX;
        limitMaxY = sizeY;
    }

    void LateUpdate()
    {
        FollowTarget(_target);
    }

    //change x
    private void FollowTarget(GameObject target)
    {
        Vector3 targetPos = target.transform.position;
        Vector3 destination = new Vector3(targetPos.x, targetPos.y + fixY, fixZ);

        //추가 : 카메라 제한
        transform.position = Vector3.Lerp(transform.position, LimitCameraArea(destination), camSpeed * Time.deltaTime);
    }

    private Vector3 LimitCameraArea(Vector3 destination)
    {
        Vector3 result = new Vector3(Mathf.Clamp(destination.x, limitMinX + camWidth, limitMaxX - camWidth),
            Mathf.Clamp(destination.y, limitMinY + camWidth, limitMaxY - camWidth),
            fixZ); 
        return result;
    }
}
