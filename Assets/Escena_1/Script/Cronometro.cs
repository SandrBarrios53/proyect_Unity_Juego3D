using UnityEngine;
using TMPro;

public class Cronometro : MonoBehaviour
{
    public float tiempo = 30f;
    public TextMeshProUGUI textoTiempo;

    public static bool juegoActivo = true;

    void Update()
    {
        if (tiempo > 0)
        {
            tiempo -= Time.deltaTime;
            textoTiempo.text = "Tiempo: " + Mathf.Ceil(tiempo).ToString();
        }
        else
        {
            textoTiempo.text = "FIN";
            juegoActivo = false;
        }
    }
}
