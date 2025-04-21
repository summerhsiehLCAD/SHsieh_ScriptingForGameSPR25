using UnityEngine;

public class SpriteMovement : MonoBehaviour
{
    public float speed = 4f;

    public float xRange;

    public float yRange;

    public Vector3 Direction;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        xRange =  Random.Range(-11f, 11f);

        yRange = Random.Range(-8f, 8f);
    }

    // Update is called once per frame
    void Update()
    {
       this.gameObject.transform.position += new Vector3 (xRange, yRange, 0f) * speed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if we collide with a horizontal wall, multiply direction.x * -1
        //if we collide with a verticlal wall, multiply direction.y *-1

        if (collision.gameObject.tag == "Horizontal")
        {
            Debug.Log(collision.gameObject);
            yRange *= -1;
        }

        else if (collision.gameObject.tag == "Vertical")
        {
            Debug.Log(collision.gameObject);
            xRange *= -1;
        }
    }
}
