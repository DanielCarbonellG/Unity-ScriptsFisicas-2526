using UnityEngine;

public class MoverConEspacio : MonoBehaviour
{
    // Vector de desplazamiento configurable desde el Inspector
    public Vector3 desplazamiento;

    // Posición original del objeto
    private Vector3 posicionOriginal;

    // Controla si ya se movió
    private bool movido = false;

    void Start()
    {
        // Guardar la posición original del objeto
        posicionOriginal = transform.position;
    }

    void Update()
    {
        // Detectar si se presiona la barra espaciadora (una vez)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!movido)
            {
                // Mover el objeto a su nueva posición
                transform.position = posicionOriginal + desplazamiento;
                movido = true;
                Debug.Log(gameObject.name + " movido a nueva posición: " + transform.position);
            }
            else
            {
                // Volver a la posición original si ya estaba movido
                transform.position = posicionOriginal;
                movido = false;
                Debug.Log(gameObject.name + " volvió a posición original: " + transform.position);
            }
        }
    }
}
