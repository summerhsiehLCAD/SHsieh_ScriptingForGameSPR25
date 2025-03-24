using System.Collections;
using JetBrains.Annotations;
using UnityEngine;

public class WhileLoopTest : MonoBehaviour
{
    public float speed = 3f;

    Coroutine co;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*
        while (this.transform.position.x < 7f)
         {
             this.transform.position += Vector3.right * speed * Time.deltaTime;
         }
        */
        //this will cause the object to move almost instantiously, in one frame. 

        co = StartCoroutine(MoveRightAndChangeColor());
    }

    // Update is called once per frame
    void Update()
    {
        /* 
        while (this.transform.position.y < 10)
        {
            this.transform.position += Vector3.right * speed * Time.deltaTime;
        } 
        */

        if(Input.GetKeyDown(KeyCode.Space))
        {
            StopCoroutine(co);
            //Only stops this specific coroutine.
        }

        if(Input.GetKeyDown(KeyCode.D))
        {
            StopAllCoroutines();
            //Stops all coroutines on the script.
        }
    }

    IEnumerator MoveRightAndChangeColor()
        //Coroutine basically allows you to pause code for certain frames, or seconds, then resume the code.
        //Makes everything a lot more streamlined.
    {
        /*
        Debug.Log("Frame 1 Runs");
        yield return null; //yield return null will pause the code until the next frame.
        Debug.Log("Frame 2 Runs");
        yield return new WaitForSeconds(2f); // This will wait 2 seconds before continuing the code.
        Debug.Log("Waited 2 seconds before posting this");
        */

        while (this.transform.position.x < 7f)
        {
            this.transform.position += Vector3.right * speed * Time.deltaTime;
            yield return null;
        }

        yield return new WaitForSeconds(2f);

        this.GetComponent<MeshRenderer>().material.color = Color.blue;

        yield return new WaitForSeconds(2f);


        while (this.transform.position.x > 0)
        {
            this.transform.position += Vector3.left * speed * Time.deltaTime;
            yield return null;
        }
        //This will move the object little by little, by each frame, stopping then repeating it until it stops. 

        yield return new WaitForSeconds(2f);

        this.GetComponent<MeshRenderer>().material.color = Color.red;
    }
}
