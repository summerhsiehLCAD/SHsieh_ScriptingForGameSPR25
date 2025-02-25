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
        Debug.Log(timeRangeRandom);
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

        foreach (BooGhost ghost in ghosts)
        {
            ghost.booDisappear();
            ghost.BooTimer();
        }
        
    }

    void booDisappear()
    {
        this.gameObject.GetComponent<MeshRenderer>().material.color = new Color(207, 255, 253, Random.Range(0f, 115f));
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

    // PLEASE TALK TO ANTHONY ABOUT BOO DISAPPEARING AND THE ALPHA NOT SHOWING PROPERLY (IT WORKED NVM)
    // GO AND FIX THE ISSUE WITH BOUNDARY CLIPPING

}
