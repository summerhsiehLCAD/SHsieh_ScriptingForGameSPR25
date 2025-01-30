using UnityEngine;

public class Script1 : MonoBehaviour
{
    int Kraken = 32;
    int Sok = 25;
    int Selene = 18;
    int total; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Selene = Selene * Kraken * Sok + Sok * 3;

        total = Selene * 5 + 10;

        Debug.Log(total);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
