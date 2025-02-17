using UnityEngine;

public class PlatformScript : MonoBehaviour
{
    public GameObject appearPlatform;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider ball)
    {
        {
            appearPlatform.SetActive(true);
        }
    }
}
