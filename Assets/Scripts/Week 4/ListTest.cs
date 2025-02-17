using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ListTest : MonoBehaviour
{
    public GameObject cannonballpreFab;

    public List<CannonBall> cannonballs = new List<CannonBall>();
    //list uses System.Collections.Generic; (right click and select Quick Actions / refactorings

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cannonballs = FindObjectsByType<CannonBall>(FindObjectsSortMode.None).ToList();
        //Find by type finds all objects in the scene that has cannonball script on it and turns it into a 
        //list to be used by the cannonballs variable, which is a list of cannonball scripts.

        //Finds all gameobjects in the scene with the specified tag. Returns it as an Array of GameObjects that you can convert to a list.
       // GameObject.FindGameObjectsWithTag("CannonBall").ToList();

        GameObject go = Instantiate(cannonballpreFab);
        cannonballs.Add(go.GetComponent<CannonBall>());
        //You can add an object directly to a list by calling the list variable's name.Add();
        //Has to be the same type as the list. If you have a list of gameobjects,
        //make sure to give it a GameObject.
        //In this case we have a cannonball script that we want to add to the list of cannonball scripts.
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //a foreach loop will go through each object in a List and allow you to do the same
            //action for every single instance in that list.
            foreach (CannonBall ball in cannonballs)
            {
                ball.AddRandomForce();
            }
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            int randomball = Random.Range(0, cannonballs.Count);

            //cannonballs.Count -1 is a reference to the last element
            cannonballs[randomball].AddRandomForce();
        }
    }
}
