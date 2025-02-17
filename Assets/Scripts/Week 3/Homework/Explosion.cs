using UnityEngine;

public class Explosion : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision ball)

    {
        ball.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * 1000);
    }
}
