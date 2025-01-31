using UnityEngine;

public class CreateObj2 : MonoBehaviour
{
    public GameObject prefab;

    private GameObject square;

    void Start()
    {
        if(prefab != null)
        {
            square = Instantiate(prefab);
            Destroy(square, 5.0f);
        }
    }

    void Update()
    {
        
    }
}
