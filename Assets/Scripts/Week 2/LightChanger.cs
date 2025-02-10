using UnityEngine;

public class LightChanger : MonoBehaviour
{
    public Light lightWeWantTochange;

    public Vector3 lightMoveDirection;

    public bool isItOrIsntIt = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        

        ChangeLightColor(Color.green);
        //ChangeLightColor(Color.blue); //whatever we pass into this function is what the
        //function is going to change the color to.

        this.gameObject.SetActive(isItOrIsntIt);
        //lightWeWantTochange.gameObject.SetActive(false);

        //Destroy(lightWeWantTochange.gameObject) <- This is how you destroy an object.
    }

    // Update is called once per frame
    void Update()
    {
        //This is how to call something within the same code)
        //AdjustLight(); //the code in this function will be called at the start 
        //of each update before moving on to the rest of the code in Update().
        Debug.Log("LightObject has been Adjusted");

        if(Input.GetKeyDown(KeyCode.R))
        {
            ChangeLightColor(Color.red);
        }

        if(Input.GetKeyDown(KeyCode.B))
        {
            ChangeLightColor(Color.blue);
        }

        if(Input.GetKeyDown(KeyCode.G))
        {
            ChangeLightColor(Color.green);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            lightWeWantTochange.gameObject.SetActive(false);
        }

        if(Input.GetKeyDown(KeyCode.V))
        {
            lightWeWantTochange.gameObject.SetActive(true);
        }
    }

    private void AdjustLight()
    {
        lightWeWantTochange.transform.position += lightMoveDirection * Time.deltaTime;
        lightWeWantTochange.intensity += 40f * Time.deltaTime;
        lightWeWantTochange.spotAngle += 70f * Time.deltaTime;
    }

    public void ChangeLightColor(Color Santa)
    {
        lightWeWantTochange.color = Santa;
        //Santa acts as a placeholder name for anything that gets passed in.

        if(lightWeWantTochange.color == Color.green)
        {
            lightWeWantTochange.intensity = 100f;
        }
        else if(lightWeWantTochange.color == Color.red)
        {
            lightWeWantTochange.transform.position += Vector3.right * 3;
            //Vector3.right will move the object to its right x axis by 3 positive spaces.
        }
        else if(lightWeWantTochange.color == Color.blue)
        {
            lightWeWantTochange.gameObject.SetActive(false);
        }
        else
        {
            lightWeWantTochange.transform.position = Vector3.zero;
            //if none of the conditions above were met, do this if it's anything other than gree, red, or blue.
        }

        if(lightWeWantTochange.color == Color.green || lightWeWantTochange.color == Color.red)
        {
            {
                //if the color is green or red, it will run this code.
            }
        }

        if(lightWeWantTochange.color == Color.blue && lightWeWantTochange.intensity > 50f)
        {
            // If the color is blue AND the intensity of the light is greter than 5-. it will run this code.
        }

        if(lightWeWantTochange.color == Color.white || (lightWeWantTochange.color == Color.black && lightWeWantTochange.intensity <= 25f))
        {
            //if the color is white, OR the color is both black and its intensity is less than or greater than 35, it will run this code.
        }
    }

    private void OnEnable() //A private function can only be called from within the script.
    {
       //when this ovhect is set active again from inactive, 
       //it will call the code in this function.
    }

    private void OnDisable()
    {
        //when this object is disabled, run the code in here before it is disabled.
    }

    private void Awake()
    {
        //is called before the start. 
    }

    private void OnDestroy()
    {
        //this is called when an object is going to be destroted before it is 
        //finsihed being destroyed.
    }
}
