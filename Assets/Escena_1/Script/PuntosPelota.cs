using UnityEngine;

public class PuntosPelota : MonoBehaviour
{
    public static int puntos = 0;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnMouseDown()
    {
        if (!Cronometro.juegoActivo) return;

        puntos++;

        if (audioSource != null)
            audioSource.Play();

        Destroy(gameObject, 2f);
        Debug.Log("Puntos: " + puntos);
    }
}