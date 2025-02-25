using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timer = 30f;

    public TextMeshProUGUI timerText;

    public bool hasTimerFinished = false;

    public UI_Counter counterScript;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(hasTimerFinished == false)
        {
            if (timer > 0)
            {
                timer -= Time.deltaTime;
            }
            else
            {
                Debug.Log("TimerHasStopped");
                hasTimerFinished = true;
                counterScript.allowCounting = false;
                timer = 0f;
            }

            timerText.text = Mathf.Ceil(timer).ToString("F0");
        }
      
    }
}
