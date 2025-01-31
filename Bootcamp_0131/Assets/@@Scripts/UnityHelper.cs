using UnityEngine;

public class UnityHelper : MonoBehaviour
{
    #region Instantiate
    public static GameObject InstantiatePrefab(GameObject obj)
    {
        if (obj != null)
        {
            return Instantiate(obj);
        }
        return null;
    }

    /// <summary>
    /// Quaternion identity, Vector3
    /// </summary>
    public static GameObject InstantiatePrefab(GameObject obj ,float x, float y, float z)
    {
        if (obj != null)
        {
            return Instantiate(obj, new Vector3(x, y, z), Quaternion.identity);
        }
        return null;
    }

    /// <summary>
    /// Random create : radius is limits area size.
    /// </summary>
    public static GameObject InstantiatePrefab(GameObject obj, float radius)
    {
        if (obj != null) 
        {
            Vector3 position = new Vector3(Random.Range(-radius, radius), Random.Range(-radius, radius), 0f);
            return Instantiate(obj, position, Quaternion.identity);
        }
        return null;
    }

    #endregion
}
