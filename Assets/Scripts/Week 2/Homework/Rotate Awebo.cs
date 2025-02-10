using UnityEngine;

public class RotateAwebo : MonoBehaviour
{
    public AweboFly aweboController;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        aweboController.RotateAweboFly();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
