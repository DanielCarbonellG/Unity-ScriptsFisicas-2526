using UnityEngine;

public class CuboControl : MonoBehaviour
{
    public float velocidad = 5f;

    void Update()
    {
        // Convertir el valor de los ejes a -1, 0 o 1
        int ejeHorizontal = Mathf.RoundToInt(Input.GetAxisRaw("Horizontal"));
        int ejeVertical = Mathf.RoundToInt(Input.GetAxisRaw("Vertical"));

        // Flecha ARRIBA
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            float resultado = velocidad * ejeVertical;
            Debug.Log("Flecha ARRIBA: " + resultado);
        }

        // Flecha ABAJO
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            float resultado = velocidad * ejeVertical;
            Debug.Log("Flecha ABAJO: " + resultado);
        }

        // Flecha IZQUIERDA
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            float resultado = velocidad * ejeHorizontal;
            Debug.Log("Flecha IZQUIERDA: " + resultado);
        }

        // Flecha DERECHA
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            float resultado = velocidad * ejeHorizontal;
            Debug.Log("Flecha DERECHA: " + resultado);
        }
    }
}
