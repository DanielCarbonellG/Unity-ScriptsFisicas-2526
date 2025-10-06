using UnityEngine;

public class MovimientoConRotacion : MonoBehaviour
{
    public float velocidadMovimiento = 5f; // velocidad hacia adelante
    public float velocidadGiro = 90f;      // velocidad de rotación en grados por segundo

    void Update()
    {
        // --- Entrada del usuario ---
        float rotacion = Input.GetAxis("Horizontal"); // Izquierda (-1), Derecha (+1)
        float avance = Input.GetAxis("Vertical");     // Adelante/Atrás (W/S o flechas)

        // --- Rotar el objeto sobre su eje Y (horizontalmente) ---
        transform.Rotate(0, rotacion * velocidadGiro * Time.deltaTime, 0);

        // --- Avanzar en la dirección hacia adelante ---
        transform.Translate(Vector3.forward * avance * velocidadMovimiento * Time.deltaTime);

        // --- Depuración visual ---
        Debug.DrawRay(transform.position, transform.forward * 2f, Color.red);
    }
}
