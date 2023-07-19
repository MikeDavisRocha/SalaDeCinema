using UnityEngine;

public class SFXManager : MonoBehaviour
{
    [Header("SFX")]
    public AudioSource hoverSound;
    public AudioSource clickSound;

    public void PlayHover()
    {
        hoverSound.Play();
    }

    public void PlayClick()
    {
        clickSound.Play();
    }
}
