using UnityEngine;

public class Disparo : MonoBehaviour
{
    void Update()
    {
        // Detectar si se pulsa la tecla H a través del Input Manager
        float disparo = Input.GetAxis("Disparo");

        if (disparo > 0)
        {
            // Llamamos a la función disparo
            Disparar();
        }
    }

    void Disparar()
    {
        Debug.Log("¡Disparo activado!");
    }

}
