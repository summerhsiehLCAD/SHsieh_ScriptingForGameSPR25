using UnityEngine;

public class BeefMarioifer : MonoBehaviour
{
    public GameObject beegMario;
    public float scaleIncrease = .5f;
    public GameObject WastedScreen;

    public Vector3 rotationAmount;

    public Transform teleportTransform;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        beegMario.transform.localScale += Vector3.one * scaleIncrease * Time.deltaTime;

        if(beegMario.transform.localScale.x > 34)
        {
            WastedScreen.SetActive(true);
        }
    }

    public void ResetBeegMario()
    {
        beegMario.transform.localScale = Vector3.one;
        scaleIncrease += .5f;
    }

    public void RotateBeegMario()
    {
        //the following line will rotate BeegMario by -120 degrees in the z direction
        //by creating a new vector3 variable to be used once at runtime.
        //beegMario.transform.Rotate(new Vector3(0f, 0f, -120f));

        //Alternatively, you can create a variable of type Vector3 to pass into 
        //the rotate function, like in the following line. This makes it so that you can 
        //functionality in the inspector without having to change any code.

        beegMario.transform.Rotate(rotationAmount);
    }
    public void TeleportBeegMario()
    {
        beegMario.transform.position = teleportTransform.position;
    }
}
