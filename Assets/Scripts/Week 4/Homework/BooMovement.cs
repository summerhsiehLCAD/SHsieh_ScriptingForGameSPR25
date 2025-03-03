using UnityEngine;

public class BooMovement : MonoBehaviour
{
    public Rigidbody rbody;

    public Vector3 moveDirection;

    public float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        speed = Random.Range(20f, 40f);

        rbody.AddForce(moveDirection * speed * Time.deltaTime);

    }
    private void OnCollisionEnter(Collision collision)
    {
        ChangeDirection();
    }

    void ChangeDirection()
    {
        moveDirection = new Vector3(Random.Range(-8f,8f), Random.Range(-5,5f), -2f);
    }

    
}
