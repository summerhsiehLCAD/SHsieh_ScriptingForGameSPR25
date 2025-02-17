using UnityEngine;

public class MoveObjectWithDirections : MonoBehaviour
{
    public GameObject Point1;
    public GameObject Point2;

    public float speed = 4f;

    public bool hasReachedDestination = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame

    /*
     void Update()
     {
         //This gets the direction every frame, updating when point 1 moves.
         //This causes the point1 object to slowly creep towards point 2, slowing down when it gets closer.
         Vector3 direction;

         direction = Point2.transform.position - Point1.transform.position;
         Debug.Log(direction);

         Point1.transform.position += direction * Time.deltaTime;
     }
 }*/

    // This version normalizes the direction of the movement vector, 
    //so it travels steadily until point2, multi. by a speed variable. 
    //Unfortunately it jitters as it reaches he end because it always tried to move past the 
    //the exact location of point 2, causing it to move back and forth until it reaches 
    //the exact point.

    /* private void Update()
    {
        Vector3 direction;

        direction = Point2.transform.position - Point1.transform.position;

        direction = direction.normalized;
        Debug.Log(direction);

        Point1.transform.position += direction * speed * Time.deltaTime;
    }

}*/

    //In this version of update, we check the distance between point 1 and point 2. If it is close enough (within .1 unit)
    //which is visually not noticeable. And it will stop trying to move point 1 towards point 2.
    //However, it is still teleporting it every frame, but I want to stop it once it reaches the proper location.

    /* private void Update()
    {
        Vector3 direction;

        direction = Point2.transform.position - Point1.transform.position;

        direction = direction.normalized;

        // Vector3.Distance will do the distance formula for you.
        Debug.Log(Vector3.Distance(Point1.transform.position, Point2.transform.position));

        if (Vector3.Distance(Point2.transform.position, Point2.transform.position) < .1f)
        {
            Point1.transform.position = Point2.transform.position;
        }
        else
        {
            Point1.transform.position += direction * speed * Time.deltaTime;
        }
        
    }
}*/

    //This version of Update will only run if point1 hasn't reached its destination.
    //Now it will stop runnnig all code in Update once it has reached its destination.
    //because we have this hasReachDestination bool variable that checks if it hasn't.
    //but once it does reach it, we set that bool to true, preventing the code from running.
    private void Update()
    {
        if (hasReachedDestination == false)
        {
            Vector3 direction;

            direction = Point2.transform.position - Point1.transform.position;

            direction = direction.normalized;

            // Vector3.Distance will do the distance formula for you.
            Debug.Log(Vector3.Distance(Point1.transform.position, Point2.transform.position));

            if (Vector3.Distance(Point1.transform.position, Point2.transform.position) < .1f)
            {
                Point1.transform.position = Point2.transform.position;
                hasReachedDestination = true;
            }
            else
            {
                Point1.transform.position += direction * speed * Time.deltaTime;
            }

        }

    }

}

