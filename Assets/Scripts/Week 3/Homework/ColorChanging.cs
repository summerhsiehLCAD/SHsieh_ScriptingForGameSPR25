using UnityEngine;

public class ColorChanging : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision otherObject)
    {
        if (otherObject.gameObject.tag == "ColorShift")
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Green")
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
        }
        else if (other.gameObject.tag == "Yellow")
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.yellow;
        }
        else if (other.gameObject.tag == "Blue")
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
        }
    }
}
