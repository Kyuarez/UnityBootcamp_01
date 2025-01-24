using UnityEngine;


/// <summary>
/// Unity Docs Ex Code
/// </summary>
[CreateAssetMenu(fileName = "SpawnManagerSO", menuName = "Scriptable Objects/SpawnManagerSO", order = 1)]
public class SpawnManagerSO : ScriptableObject
{
    public string prefabName;

    public int countPrefabs;
    //TK : ������ �ٸ��� 2D ������Ʈ���� Vector2
    public Vector2[] spawnPoints;
}
