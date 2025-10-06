using UnityEngine;

public class MostrarPosicionEnPantalla : MonoBehaviour
{
    void OnGUI()
    {
        // Obtener la posición actual del objeto (esfera)
        Vector3 pos = transform.position;

        // Mostrar el vector en la pantalla del juego (arriba a la izquierda)
        GUI.Label(new Rect(10, 10, 400, 25), 
            "Posición de la esfera: " + pos.ToString("F2"));
    }
}
