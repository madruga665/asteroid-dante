using UnityEngine;

public class Sounds : MonoBehaviour
{
    public AudioSource soundTrack;
    public AudioSource gameOverSound;

    public void PlaySoundTrack()
    {
        soundTrack.Play();
    }

    public void PlayGameOverSound()
    {
        gameOverSound.Play();
    }
}
