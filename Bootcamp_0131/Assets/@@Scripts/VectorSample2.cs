using UnityEngine;

public class VectorSample2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Vector3 a = new Vector3(2, 2, 0);
        Vector3 normalA = a.normalized;

        Vector3 posA = new Vector3(1, 2, 3);
        Vector3 posB = new Vector3(2, 3, 0);
        float distance = Vector3.Distance(posA, posA);

        Vector3 lerpValue = Vector3.Lerp(posA, posB, 0.5f);
    }
}
