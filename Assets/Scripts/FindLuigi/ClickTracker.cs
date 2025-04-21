using TMPro;
using UnityEngine;

public class ClickTracker : MonoBehaviour
{
    public TextMeshProUGUI clickCount;
    
    public GameObject WinScreen;

    public int amtClicks = 0;

    public bool allowClicking = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (allowClicking == true)
        {
            UpdateUI();
        }


        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D rayhit = Physics2D.GetRayIntersection(Camera.main.ScreenPointToRay(Input.mousePosition));
            //Generates a ray cast that is based off the camera and the mouse position + the mouse input
            
            if (rayhit.transform != null) //this means that if you click on basically anything with a transform
                //Everything has a transform, so this means that if you click on ANYTHING...
            {
                Debug.Log(rayhit.transform.gameObject.name);
                if (rayhit.collider.tag == "Chiikawa")
                {
                    Debug.Log("Yay!!!");
                    WinScreen.SetActive(true);
                    allowClicking = false;
                }
                
            }
            else
            {
                Debug.Log("Womp, womp, try again!");
                amtClicks++;
            }
        }
    }

    void UpdateUI()
    {
        clickCount.text = "You missed " + amtClicks.ToString() + " times tho...";
    }
}
