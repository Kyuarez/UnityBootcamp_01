using UnityEngine;

public class CreateObj : MonoBehaviour
{
    public GameObject prefab;

    void Start()
    {
        InstantiatePrefab();
        InstantiatePrefab(3,4,0);
    }

    void Update()
    {
        
    }

    #region Instantiate
    private void InstantiatePrefab()
    {
        if (prefab != null)
        {
            Instantiate(prefab);
        }
    }

    /// <summary>
    /// Quaternion identity, Vector3
    /// </summary>
    private void InstantiatePrefab(float x, float y, float z) 
    {
        if (prefab != null)
        {
            Instantiate(prefab, new Vector3(x, y, z), Quaternion.identity);
        }
    }


    #endregion
}
