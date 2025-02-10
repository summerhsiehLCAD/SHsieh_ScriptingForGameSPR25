using UnityEngine;

public class InstantiateTest : MonoBehaviour
{
    public GameObject cannonBallPrefab;

    public GameObject cannonBallSpawnPos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject go = Instantiate(cannonBallPrefab, cannonBallSpawnPos.transform.position, cannonBallPrefab.transform.rotation);

        go.GetComponent<MeshRenderer>().material.color = Color.black;
      
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space)) //if we are holding dpon the space key, it will run the code.
        {
            Instantiate(cannonBallPrefab, cannonBallSpawnPos.transform.position, cannonBallPrefab.transform.rotation);
        }
    }
}
