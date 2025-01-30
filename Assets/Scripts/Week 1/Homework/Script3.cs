using UnityEngine;

public class Script3 : MonoBehaviour
{
    string fullSentence;
    string first = "Hi Anthony!";
    string second = "What's your favorite color?";
    string third = "Mine is yellow!";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        fullSentence = first + " " + second + " " + third;

        Debug.Log(fullSentence);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
