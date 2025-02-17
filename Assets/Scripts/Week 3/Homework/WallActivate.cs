using UnityEngine;

public class WallActivate : MonoBehaviour
{
    public GameObject wall;

    public Vector3 moveDirection;
    public float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision ball)
    {
        if (ball.gameObject.tag == "Marble")
        {
            wall.transform.position += moveDirection * speed * Time.deltaTime;
        }
    }
}
