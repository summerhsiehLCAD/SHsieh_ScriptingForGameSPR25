using UnityEngine;

public class Script2 : MonoBehaviour
{
    public float Haewoo;
    public float Kuja;
    public float Lev;
    float total;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Haewoo = Haewoo * Haewoo + 5;

        total = Haewoo + Kuja * Lev;

        Debug.Log(total);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
