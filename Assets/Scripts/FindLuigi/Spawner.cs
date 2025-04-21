using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject usagiPrefab;

    public GameObject chiiPrefab;

    public GameObject hachiPrefab;

    public GameObject kuriPrefab;

    public int hachiSpawnCount;

    public int usagiSpawnCount;

    public int kuriSpawnCount;

    [SerializeField]
    protected int chiiSpawnCount = 1;

    public GameObject spawnPos;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnHachi();
        SpawnUsagi();
        SpawnChiikawa();
        SpawnKuri();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnHachi()
    {
        hachiSpawnCount = Random.Range(10, 35);
        Debug.Log(hachiSpawnCount);

        for (int i = 0; i < hachiSpawnCount; i++)
        {
            Vector2 spawnPos = new Vector2(Random.Range(-9f, 9f), Random.Range(-4, 6f));
            Instantiate(hachiPrefab, spawnPos, Quaternion.identity);
        }
    }

    void SpawnUsagi()
    {
        usagiSpawnCount = Random.Range(10, 30);
        Debug.Log(usagiSpawnCount);

        for (int i = 0; i < usagiSpawnCount; i++)
        {
            Vector2 spawnPos = new Vector2(Random.Range(-9f, 9f), Random.Range(-4, 6f));
            Instantiate(usagiPrefab, spawnPos, Quaternion.identity);
        }
    }

    void SpawnKuri()
    {
        kuriSpawnCount = Random.Range(10, 30);
        Debug.Log(kuriSpawnCount);

        for (int i = 0; i < kuriSpawnCount; i++)
        {
            Vector2 spawnPos = new Vector2(Random.Range(-9f, 9f), Random.Range(-4, 6f));
            Instantiate(kuriPrefab, spawnPos, Quaternion.identity);
        }
    }

    void SpawnChiikawa()
    {
        chiiSpawnCount = 1;
        Debug.Log(chiiSpawnCount);

        for (int i = 0; i < chiiSpawnCount; i++)
        {
            Vector2 spawnPos = new Vector2(Random.Range(-9f, 9f), Random.Range(-4, 6f));
            Instantiate(chiiPrefab, spawnPos, Quaternion.identity);
        }
    }
}
