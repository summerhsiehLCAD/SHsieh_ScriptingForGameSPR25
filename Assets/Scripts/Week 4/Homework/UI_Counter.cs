using UnityEngine;
using TMPro;

public class UI_Counter : MonoBehaviour
{
    public TextMeshProUGUI scoreCounter;

    public TextMeshProUGUI actualCount;

    public int counter = 0;

    public bool allowCounting = true;

    public BooSpawn listScript;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (allowCounting == true)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                CountUp();
            }

            if (Input.GetKeyDown(KeyCode.B))
            {
                CountDown();
            }
        }
      
    }

    void CountUp()
    {
        counter++;
        UpdateCounterUI();
    }

    void CountDown()
    {
        counter--;

        if (counter < 0)
        {
            counter = 0;
        }

        UpdateCounterUI();
    }

    void UpdateCounterUI()
    {
        scoreCounter.text = counter.ToString();
    }

    public void ActualCounterUI()
    {
        actualCount.text = "There were " + listScript.booSpawnCount.ToString() + " Boos!";
    }
}
