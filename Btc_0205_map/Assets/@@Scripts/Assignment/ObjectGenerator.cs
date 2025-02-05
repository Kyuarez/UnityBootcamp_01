using UnityEngine;


/*
 마우스 버튼 클릭 시, 카메라의 스크린 지점을 통해 물체 방향 설정
물체를 방향에 맞춰 발사 하는 기능
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
