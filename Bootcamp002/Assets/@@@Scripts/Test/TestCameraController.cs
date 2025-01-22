using UnityEngine;

/// <summary>
/// �ӽ� ī�޶� ��Ʈ�ѷ� Ŭ����
/// - �ӽ� �÷��̾� �����ؼ� �˾Ƽ� ���󰡰�
/// </summary>
public class TestCameraController : MonoBehaviour
{
    private Camera _Camera;
    private GameObject _Player;

    [SerializeField] private Vector3 _fixPos = new Vector3(0f, 5f, -5f);
    [SerializeField] private float fixAngle = 45f;
    [SerializeField] private float cameraMoveSpeed = 2f;

    private void Awake()
    {
        _Camera = GetComponent<Camera>();
    }

    void Start()
    {
        TopViewSet();
    }

    private void LateUpdate()
    {
        //�÷��̾� ��ġ�� ���� ������Ʈ
        Vector3 _destination = new Vector3(_Player.transform.position.x, _Player.transform.position.y + _fixPos.y, _Player.transform.position.z + _fixPos.z); 
        _Camera.transform.position = Vector3.Lerp(_Camera.transform.position, _destination, cameraMoveSpeed * Time.deltaTime);
    }

    private void TopViewSet()
    {
        //�÷��̾� �����ϰ�, �÷��̾� ��ġ���� ž��� ��ġ ����
        _Player = GameObject.Find("@@Player");
        Transform playerTransform = _Player.transform;
        _Camera.transform.position = new Vector3(playerTransform.position.x, playerTransform.position.y + _fixPos.y, _fixPos.z + playerTransform.position.z);
        _Camera.transform.rotation = Quaternion.Euler(fixAngle, 0, 0);
    }
}
