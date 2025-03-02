using System.Collections.Generic;
using UnityEngine;

public class BooGhost : MonoBehaviour
{
    public float timeRangeRandom;

    public List<BooGhost> ghosts = new List<BooGhost>();

   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timeRangeRandom = Random.Range(5f, 10f);
        //make the boo disappear after a set amt of time
       
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
            ghost.booDisappear();
            ghost.BooTimer();
        }
        
    }

   void booDisappear()
    {
        this.gameObject.SetActive(false);
    }
    
    void BooTimer()
    {
        float timeRangeRandom = Random.Range(5f, 10f);
        timeRangeRandom -= Time.deltaTime;

        if (timeRangeRandom >= 0)
        {
            booDisappear();
        }
    }

    // PLEASE TALK TO ANTHONY ABOUT BOO DISAPPEARING 
    // GO AND FIX THE ISSUE WITH BOUNDARY CLIPPING

}
