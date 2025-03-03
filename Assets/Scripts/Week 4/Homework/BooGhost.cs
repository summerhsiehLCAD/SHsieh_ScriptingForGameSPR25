using System.Collections.Generic;
using UnityEngine;

public class BooGhost : MonoBehaviour
{
    public float timeRangeRandom;

    public List<BooGhost> ghosts = new List<BooGhost>();

   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
        //make the boo disappear after a set amt of time
        timeRangeRandom = Random.Range(10f, 15f);

    }

    // Update is called once per frame
    void Update()
    {
        /* for (int i = 0; i < timeRangeRandom; i++)
         {

             {
                 booDisappear();
             }
         }*/

        //StartCoroutine(ToggleObjectVisibility(timeRangeRandom));

        foreach (BooGhost ghost in ghosts)
        {
            ghost.BooTimer();
            ghost.booDisappear();
        }
        
    }

    void BooTimer()
    {

        timeRangeRandom -= Time.deltaTime;

        if (timeRangeRandom >= 0)
        {
            booDisappear();
        }
    }

    void booDisappear()
    {
        this.gameObject.SetActive(false);
    }
    
   

    // PLEASE TALK TO ANTHONY ABOUT BOO DISAPPEARING 
    // GO AND FIX THE ISSUE WITH BOUNDARY CLIPPING

}
