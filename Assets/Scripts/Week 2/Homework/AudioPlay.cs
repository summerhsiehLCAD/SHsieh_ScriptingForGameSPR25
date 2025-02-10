using UnityEngine;

public class AudioPlay : MonoBehaviour
{
    public AweboFly aweboAudio;

    AudioSource Game;
    AudioSource awebosound;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        awebosound.Play();
    }

    void OnBecomeVisible()
    {
        Game.Play();
    }

}
