using UnityEngine;

public class AweboFly : MonoBehaviour
{
    public GameObject Awebo;
    public Vector3 moveDirection;

    public float speed;

    public GameObject GameScreen;

    public GameObject powerAwebo;

    public Vector3 rotationAmount;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Awebo.transform.position += moveDirection * speed * Time.deltaTime;

        if (Awebo.transform.localPosition.y > 620)
        {
            GameScreen.SetActive(true);
        }

        if(Input.GetKeyDown(KeyCode.A))
        {
            powerAwebo.SetActive(true);
        }
    }

    public void RotateAweboFly()
    {
        Awebo.transform.Rotate(rotationAmount);
        Awebo.transform.Rotate(rotationAmount);
    }
}
