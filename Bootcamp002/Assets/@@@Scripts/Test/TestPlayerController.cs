using UnityEngine;

/*
 임시 플레이어 컨트롤러
 */
public class TestPlayerController : MonoBehaviour
{
    [SerializeField]
    private CharacterController _Controller;
    [SerializeField]
    private float _MoveSpeed = 2f;

    private void Awake()
    {
        _Controller = GetComponent<CharacterController>();
    }

    void Start()
    {
        
    }
    void Update()
    {
        BasicMove();

        //점프 기능
    }

    private void BasicMove()
    {
        float moveFactorX = Input.GetAxis("Horizontal");
        float moveFactorZ = Input.GetAxis("Vertical");
        if (moveFactorX >= 1f || moveFactorX <= -1)
        {
            float _distanceX = moveFactorX * _MoveSpeed;
            transform.Translate(_distanceX * Time.deltaTime, 0f, 0f);
        }
        if(moveFactorZ >= 1f || moveFactorZ <= 1f)
        {
            float _distanceZ = moveFactorZ * _MoveSpeed;
            transform.Translate(0f, 0f, _distanceZ * Time.deltaTime);
        }
    }
}
