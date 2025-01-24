using UnityEngine;


/// <summary>
/// Unity Docs Ex Code
/// </summary>
[CreateAssetMenu(fileName = "SpawnManagerSO", menuName = "Scriptable Objects/SpawnManagerSO", order = 1)]
public class SpawnManagerSO : ScriptableObject
{
    public string prefabName;

    public int countPrefabs;
    //TK : 예제랑 다르게 2D 프로젝트여서 Vector2
    public Vector2[] spawnPoints;
}
