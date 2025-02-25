using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject cannonballPrefab;

    public Transform cannonballSpawnPosition;

    public float forcePower = 500f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    /* void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FireCannon();
        }
    }
    */
    public void FireCannon()
    {
        // This instantiates the gameobject, and "go" will be our game object that is spawning.
        GameObject go = Instantiate(cannonballPrefab, cannonballSpawnPosition.position, cannonballSpawnPosition.rotation);

        //go.transform.forward takes reference of the gameobject's own direction, and allows for the transform to be forward.
        go.GetComponent<Rigidbody>().AddForce(go.transform.forward * forcePower);
    }
}
