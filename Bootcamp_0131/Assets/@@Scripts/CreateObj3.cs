using System.Collections.Generic;
using UnityEngine;

public class CreateObj3 : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private GameObject sample;
    [SerializeField] private List<GameObject> objList;
    
    private int dummy;

    private void Start()
    {
        objList = new List<GameObject>();
        prefab = Resources.Load<GameObject>("Prefabs/Circle");
    }

    private void Update()
    {
        if(true == Input.GetKeyDown(KeyCode.Space))
        {
            //sample = UnityHelper.InstantiatePrefab(prefab);
            objList.Add(UnityHelper.InstantiatePrefab(prefab, 5f));
        }
    }
}
