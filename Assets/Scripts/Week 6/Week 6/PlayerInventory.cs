using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    

    public bool hasRedKey = false;

    public bool hasBlueKey = false;

    public bool hasYellowKey = false;

    public GameObject playerCamera;

    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            //Are we looking at the door?
            RaycastHit hitObject; //this variable contains the data of what will be hit by the 
            //Raycast we're about to make.

            if (Physics.Raycast(playerCamera.transform.position, playerCamera.transform.forward, out hitObject, 10f))
            {
                if (hitObject.collider.gameObject.tag == "Door")
                {
                    Door lookedAtDoor = hitObject.collider.gameObject.GetComponent<Door>();

                    if (lookedAtDoor.doorColor == KeyColor.Red && hasRedKey == true)
                    {
                        lookedAtDoor.OpenDoor();
                    }
                    else if (lookedAtDoor.doorColor == KeyColor.Blue && hasBlueKey == true)
                    {
                        lookedAtDoor.OpenDoor();
                    }
                    else if (lookedAtDoor.doorColor == KeyColor.Yellow && hasYellowKey == true)
                    {
                        lookedAtDoor.OpenDoor();
                    }

                      /*  if (hasKey == true)
                        {
                            // This will check if the hitObject is the door, then get the collider of the door, and then call the script then 
                            //the OpenDoor function.
                            hitObject.collider.gameObject.GetComponent<Door>().OpenDoor();
                        }*/
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Key")
        {
            // picked up key color will now be whatever color the key picked up is
            KeyColor pickedUpKeyColor = other.gameObject.GetComponent<Key>().color;

            if (pickedUpKeyColor == KeyColor.Red)
            {
                hasRedKey = true;
            }

            else if (pickedUpKeyColor == KeyColor.Blue)
            {
                hasBlueKey = true;
            }

            else if (pickedUpKeyColor == KeyColor.Yellow)
            {
                hasYellowKey = true;
            }

            Destroy(other.gameObject);
        }
    }
}
