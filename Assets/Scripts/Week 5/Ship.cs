using System.Collections.Generic;
using System.Linq;
using NUnit.Framework.Interfaces;
using UnityEngine;

public class Ship : MonoBehaviour
{
    public List<Cannon> cannons = new List<Cannon>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cannons = FindObjectsByType<Cannon>(FindObjectsSortMode.InstanceID).ToList();
       // cannons[0].FireCannon(); //Fires the first cannon in the list
       // cannons[1].FireCannon();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FireAllCannons();
        }

        //When I press 1 key on keyboard, fire all odd cannons. When press 2 key on keyboard, fire all even cannons.
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            FireEvenCannons();
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            FireOddCannons();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            FireAllPowerfulCannons();
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            FireAllWeakCannons();
        }
    }

    void FireAllCannons()
    {
        //Fires all cannons in a forloop
        foreach (Cannon c in cannons)
        {
            c.FireCannon();
        }

        /* for (int i = 0; i < cannons.Count; i++)
        {
            cannons[i].FireCannon();
        }*/
    }

    void FireEvenCannons()
    {
        //index creation: int = whole number variable, to declare you are choosing a specific whole number in the list
        //this will create the index/list of variables that we can choose from.
        //conditional: if the i variable is less than the total number of cannons, it will continue the loop
        //increase index: i++ (adds one to the index)
        for (int i = 0; i < cannons.Count; i++)
        {
            //if it's odd, don't fire, if it's even, fire.

            //the mod operator (%) does division between two numbers
            //and returns the remainder. If the remainder of something % 2 is 0, it is even!
            if (i % 2 == 0)
            {
                cannons[i].FireCannon();
            }

        }
    }

    void FireOddCannons()
    {
        for (int i = 0; i < cannons.Count; i++)
        {
            if (i % 2 == 1)
            {
                cannons[i].FireCannon();
            }
        }
    }

    //Fire all cannons that have a force power of 4500+ on the S Key
    void FireAllPowerfulCannons()
    {
        foreach (Cannon c in cannons)
        {
            if (c.forcePower >= 4500)
            {
                c.FireCannon();
            }
        }
    }

    void FireAllWeakCannons()
    {
        for (int i = 0; i < cannons.Count; i++)
        {
            if (cannons[i].forcePower < 4500)
            {
                cannons[i].FireCannon();
            }
        }
    }
}
