using UnityEngine;

public class Homework_MarbleSpawner : MonoBehaviour
{
    public GameObject marbleSpawnPos;

    public GameObject marblePrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(marblePrefab, marbleSpawnPos.transform.position, marblePrefab.transform.rotation);
        }
    }
}
