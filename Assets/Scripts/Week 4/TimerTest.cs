using UnityEngine;

public class TimerTest : MonoBehaviour
{
    public float timerCountingUp = 0f;
    public float timerMaxDuration = 3f;

    public bool hasFinishedTimer = false;

    public GameObject cube;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //When using Random.Range, if you put f after the numbers in the function,
        //it will return a decimal number between those two numbers. if you do not put an f after the 
        //number, it will return whole numbers.
        //Example: Random.Range (1,4) will return 1, 2, 3 but not 4
        //Example: Random.Range (1f, 4f) will return anything between 1-4.
        timerMaxDuration = Random.Range(1f, 4f);

        Invoke("MoveCubeRight", timerMaxDuration);
    }

    // In this update, once the timer finishes, it changes a bool called hasFinishedTimer
    //to true, which prevents additional logic from being run for the timer. 
    //this is how you can make sure something only happens once based on a timer.
    /*
    void Update()
    {
        if (hasFinishedTimer == false)
        {
            timerCountingUp += Time.deltaTime;
            // Debug.Log(timerCountingUp);

            if (timerCountingUp >= timerMaxDuration)
            {
                hasFinishedTimer = true;
                Debug.Log("Reached End of Timer");
            }
        }
    }*/
    //In this update, the timer counts up, but once it reaches the timerMaxDuration
    //it will move the cube to the right WITHOUT time.deltaTime, because we want it to move
    //in one motion, not over time. Additionally, we reset the timeCountup to 0 so that
    //it will count back up to 3 again and move the cube again.
    /*
     void Update()
    {
        timerCountingUp += Time.deltaTime;
       
        if (timerCountingUp >= timerMaxDuration)
        {
            Debug.Log("Reached End of Timer");

            cube.transform.position += Vector3.right;

            timerCountingUp = 0f;
        }
    }*/

    void MoveCubeRight()
    {
        cube.transform.position += Vector3.right;

        if(cube.transform.position.x < 10)
        {
            Invoke("MoveCubeRight", timerMaxDuration);
        }
        

    }

}
