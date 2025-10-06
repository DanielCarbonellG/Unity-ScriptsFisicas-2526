using UnityEngine;

public class CuboSigueEsfera : MonoBehaviour
{
    public GameObject esfera;  // arrástrala desde el inspector
    public float speed = 3f;   // velocidad configurable en el inspector

    void Update()
    {
        if (esfera == null) return; // por si no se ha asignado

        // Posición actual del cubo
        Vector3 posicionCubo = transform.position;

        // Posición de la esfera
        Vector3 posicionEsfera = esfera.transform.position;

        // Queremos movernos hacia la esfera pero sin cambiar la altura del cubo
        posicionEsfera.y = posicionCubo.y;

        // Vector dirección (de cubo → esfera)
        Vector3 direccion = (posicionEsfera - posicionCubo).normalized;

        // Movimiento proporcional al tiempo
        transform.Translate(direccion * speed * Time.deltaTime, Space.World);
    }
}
