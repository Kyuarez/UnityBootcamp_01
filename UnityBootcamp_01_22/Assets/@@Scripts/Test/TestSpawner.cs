using UnityEngine;

/// <summary>
/// UnityDocs Ex Code
/// </summary>
public class TestSpawner : MonoBehaviour
{
    public GameObject entityToSpawn;

    public SpawnManagerSO _spawnManager;

    int instanceNumber = 1;

    private void Start()
    {
        SpawnEntities();
    }

    void SpawnEntities()
    {
        int index = 0;

        for (int i = 0; i < _spawnManager.countPrefabs; i++)
        {
            GameObject obj = Instantiate(entityToSpawn, _spawnManager.spawnPoints[index], Quaternion.identity);

            obj.name = _spawnManager.prefabName + instanceNumber;

            index = (index + 1) % _spawnManager.spawnPoints.Length;

            instanceNumber++;
        }
    }
}
