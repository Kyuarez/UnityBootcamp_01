using UnityEngine;
using static UnityEngine.ParticleSystem;

/*
 발사 기능을 제공해주는 클래스
 충돌 시 오브젝트를 고정시켜주는 역할
 */

[RequireComponent(typeof(Rigidbody))]
public class ObjectShooter : MonoBehaviour
{
    private GameObject objectGenerator;
    private Rigidbody rigid;
    private ParticleSystem particle;

    private float throwPower = 100f;

    private void OnEnable()
    {
        objectGenerator = GameObject.Find("ObjectGenerator");
        rigid = GetComponent<Rigidbody>();
        particle = GetComponentInChildren<ParticleSystem>();
        rigid.isKinematic = false;
    }

    public void Shoot(Vector3 direction)
    {
        direction *= throwPower;
        rigid.AddForce(direction, ForceMode.Impulse);
        //@TK : 난 처음 쏠 때 파편 느낌이라서...
        particle.Play();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (true == collision.gameObject.CompareTag("Target"))
        {
            rigid.isKinematic = true;
            AssignmentManager.Instance.AddScore();
        }
        //@TK : Temp
        else
        {
            Destroy(gameObject, 0.2f);  

        }
    }
}
