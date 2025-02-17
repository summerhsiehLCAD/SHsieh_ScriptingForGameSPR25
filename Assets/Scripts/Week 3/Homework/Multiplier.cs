using UnityEngine;

public class Multiplier : MonoBehaviour

{
    public GameObject marblePrefab;

    public GameObject marbleSpawnPos2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(marblePrefab, marbleSpawnPos2.transform.position, marblePrefab.transform.rotation);
    }
}
