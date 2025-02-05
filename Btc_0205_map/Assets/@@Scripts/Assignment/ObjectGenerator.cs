using UnityEngine;


/*
 ���콺 ��ư Ŭ�� ��, ī�޶��� ��ũ�� ������ ���� ��ü ���� ����
��ü�� ���⿡ ���� �߻� �ϴ� ���
 */
public class ObjectGenerator : MonoBehaviour
{
    private Camera mainCam;
    private GameObject prefab;

    private void Awake()
    {
        mainCam = Camera.main;
        LoadPrefab();
    }

    void Update()
    {
        
    }

    public void CreateObject()
    {
        GameObject obj = Instantiate(prefab, transform);

        var ray = mainCam.ScreenPointToRay(Input.mousePosition);
        Vector3 direction = ray.direction;

        obj.GetComponent<ObjectShooter>().Shoot(direction.normalized);
    }

    private void LoadPrefab()
    {
        prefab = Resources.Load<GameObject>(Define.RES_BAMSONGI);
        if (prefab == null)
        {
            Debug.Assert(false, "Prefabs is null (Resources's path has problem)");
        }
    }
}
