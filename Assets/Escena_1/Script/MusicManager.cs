using UnityEngine;

public class MusicaManager : MonoBehaviour
{
    public AudioSource musicaFondo;

    public void PausarMusica()
    {
        if (musicaFondo.isPlaying)
            musicaFondo.Pause();
        else
            musicaFondo.Play();
    }
}
