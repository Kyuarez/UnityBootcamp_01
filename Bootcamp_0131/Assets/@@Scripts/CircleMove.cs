using UnityEngine;

public enum MoveType 
{
    Lerp,
    MoveTowards,
    Slerp,
}

public class CircleMove : MonoBehaviour
{
    public MoveType moveType;

    private GameObject circle;
    Vector3 pos = new Vector3(5, 4, 0);
    Vector3 destination;

    private void Awake()
    {
        circle = GameObject.Find("@@Circle").gameObject;
        moveType = MoveType.Lerp;
    }

    private void Update()
    {
        // circle.transform.position = Vector3.Lerp(circle.transform.position, pos, 0.5f);
        //circle.transform.position = Vector3.MoveTowards(circle.transform.position, pos, 1f);
        //circle.transform.position = Vector3.Slerp(circle.transform.position, pos, 0.05f);

        //오른쪽 마우스 클릭    
        if (true == Input.GetMouseButtonDown(1))
        {
            destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            destination.z = 0;
        }

        switch (moveType)
        {
            case MoveType.Lerp:
                circle.transform.position = Vector3.Lerp(circle.transform.position, destination, Time.deltaTime);
                break;
            case MoveType.MoveTowards:
                circle.transform.position = Vector3.MoveTowards(circle.transform.position, destination, 0.5f);
                break;
            case MoveType.Slerp:
                circle.transform.position = Vector3.Slerp(circle.transform.position, destination, 0.02f);
                break;
            default:
                break;
        }
    }

    public void ChangeMoveType(MoveType _moveType)
    {
        moveType = _moveType;
    }
}
