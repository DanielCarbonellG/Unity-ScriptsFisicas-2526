using UnityEngine;

public class DistanciaASolidos : MonoBehaviour
{
    private GameObject cubo;
    private GameObject cilindro;

    void Start()
    {
        // Busca los objetos por su etiqueta (asegúrate de asignarlas en el inspector)
        cubo = GameObject.FindWithTag("Cubo");
        cilindro = GameObject.FindWithTag("Cilindro");

        if (cubo != null && cilindro != null)
        {
            // Calculamos la distancia entre la esfera y cada objeto
            float distanciaCubo = Vector3.Distance(transform.position, cubo.transform.position);
            float distanciaCilindro = Vector3.Distance(transform.position, cilindro.transform.position);

            // Mostramos los resultados en consola
            Debug.Log("Distancia de la esfera al cubo: " + distanciaCubo.ToString("F2"));
            Debug.Log("Distancia de la esfera al cilindro: " + distanciaCilindro.ToString("F2"));
        }
        else
        {
            Debug.LogWarning("No se encontraron los objetos con las etiquetas 'Cubo' o 'Cilindro'.");
        }
    }
}
