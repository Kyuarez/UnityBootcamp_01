using UnityEngine;

/* [플레이어 이동]
 여기서는 리지드 바디를 이용한 움직임 구현
 */

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    public float _speed = 5.0f;
    public float jump_force = 5.0f;
    public bool isJump = false;

    private Rigidbody2D rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();                    
    }

    void Update()
    {
        Move();
        Jump();
    }

    private void Move()
    {
        //GetAxisRaw return : -1 , 0 , 1
        float x = Input.GetAxisRaw("Horizontal");
        //float y = Input.GetAxisRaw("Vertical");

        Vector3 vel = new Vector3 (x, 0, 0) * _speed * Time.deltaTime;
        transform.position += vel;
    }

    private void Jump()
    {
        if(true == Input.GetKeyDown(KeyCode.Space))
        {
            if(false == isJump)
            {
                isJump = true;
                rigid.AddForce(Vector3.up * jump_force, ForceMode2D.Impulse);
            }

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == Define.LAYER_CLIMB)
        {
            //반복 점프 되게
            isJump = false;
            return;
        }

        if(collision.gameObject.layer == Define.LAYER_GROUND && rigid.linearVelocityY <= 0.01f)
        {
            isJump = false;
        }   
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == Define.TAG_PORTAL)
        {
            Debug.Log("Goal in!");
        }
    }
}
