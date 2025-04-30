using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    public AudioSource winAudio;

    public AudioSource misClickAudio;

    public void WinAudio()
    {
        winAudio.Play();
    }

    public void MisClickAudio()
    {
        misClickAudio.Play();
    }
}
