using UnityEngine;

public class AudioPlay : MonoBehaviour
{
    
    public AudioSource Game;
    public AudioSource awebosound;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void Aweboplay()
    {

        awebosound.Play();
       
    }

  }
