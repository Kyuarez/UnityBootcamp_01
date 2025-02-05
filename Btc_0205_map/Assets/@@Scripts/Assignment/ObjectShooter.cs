using UnityEngine;
using static UnityEngine.ParticleSystem;

/*
 �߻� ����� �������ִ� Ŭ����
 �浹 �� ������Ʈ�� ���������ִ� ����
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
        //@TK : �� ó�� �� �� ���� �����̶�...
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
