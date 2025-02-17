using UnityEngine;
using UnityEngine.ProBuilder.Shapes;

public class TimerCountingDown : MonoBehaviour
{
    public float timerCountingDown = 5f;
    public float timerMaxDuration = 0f;

    public GameObject cube;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //timerCountingDown = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        timerCountingDown -= Time.deltaTime;

        if (timerCountingDown <= timerMaxDuration)
        {
            Debug.Log("Reached End of Timer");

            timerCountingDown = 5f;
        }
    }

   /* void MoveCubeRight()
    {
        cube.transform.position += Vector3.right;
        Invoke("MoveCubeRight", timerMaxDuration);
    }*/
}
