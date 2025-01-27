using UnityEngine;

public class MovementTest : MonoBehaviour
{
    public Vector3 startingPosition;

    public Vector3 moveDirection;

    public float speed;

    // Anything in these slashes are not code and do not run, they are comments / notes.
    // Start is called when this object first exists in the scene and the game is loaded.
    void Start()
    {
        Debug.Log("Hello World!");

        // in reference to the object THIS script is on
        // get reference to its TRANSFORM component and get reference to the transform's POSITION, and SET it (=)
        // to Vector3.zero which means (0, 0, 0)
        this.transform.position = startingPosition;
    }

    // Update is called once per frame
    void Update()
    {
        //movedirection is currently (1,0,1)
        //multiplying by Time.deltaTime means "Per Second" instead of "Per Frame" in Update.
        this.transform.position += moveDirection * speed * Time.deltaTime;
        Debug.Log("YAHOOOOOOOOOO!");
    }
}
