using UnityEngine;

public class SFXManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip beamSound;

    public void PlayBeamSound()
    {
        audioSource.PlayOneShot(beamSound);
    }
}
