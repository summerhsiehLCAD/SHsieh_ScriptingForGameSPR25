using UnityEngine;

public class Accelerator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider ball)
    {
        ball.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.right * 1000);
    }

    private void OnTriggerExit(Collider ball)
    {
        ball.gameObject.GetComponent<MeshRenderer>().transform.localScale = Vector3.one;
    }
}
