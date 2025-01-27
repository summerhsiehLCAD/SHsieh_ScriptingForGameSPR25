using UnityEngine;

public class DatatypePractoce : MonoBehaviour
{
    int Santa;

    float total;
    public float mario;
    public float Yoshi = 4.8f;

    //characters are only allowed to be 1 letter or character on a keyboard. 
    //They also only use apostrophes to surround the character.
    char bee = 'B';

    //A string is a string of characters, could mean a word or a paragraph.
    //Make sure to use quotation marks to say what the string is.
    string fullSentence;
    string intro = "Hello World!";
    string outro = "Buh Bye!";

    public string chestName;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Santa = 69;

        Santa = Santa + 5 * 10 / (2 - 9);
        
        Debug.Log(Santa);

        Debug.Log(Yoshi);

        //Subtracts 2 from the current value of yoshi
        Yoshi = Yoshi - 2;

        //Subtracts 2 from the current value of yoshi (written diff)
        Yoshi -= 2;

        Debug.Log("Yoshi's value is " + Yoshi);

        Debug.Log(bee + intro);

        total = mario + Yoshi;

        Debug.Log(total);

        fullSentence = intro + " " + outro;

        Debug.Log(fullSentence);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
