using UnityEngine;
using TMPro;

public class UI_Puntos : MonoBehaviour
{
    public TextMeshProUGUI texto;

    void Update()
    {
        texto.text = "Puntos: " + PuntosPelota.puntos;
    }
}