using UnityEngine;

public class BooSpawn : MonoBehaviour
{
    public GameObject booGhostPrefab;

    public GameObject booGhostSpawnPos;

    public int booSpawnCount;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        

        SpawnBoos();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnBoos()
    {
        booSpawnCount = Random.Range(20, 41);
        Debug.Log(booSpawnCount);

        for (int i = 0; i < booSpawnCount; i++)
        {
            Vector3 booGhostSpawnPos = new Vector3(Random.Range(-8f, 8f), Random.Range(-5f, 5f), -2f);
            Instantiate(booGhostPrefab, booGhostSpawnPos, Quaternion.identity);
            
        }
        

         
    }
}
