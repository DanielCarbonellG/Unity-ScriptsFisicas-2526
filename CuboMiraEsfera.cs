using UnityEngine;

public class CuboMiraEsfera : MonoBehaviour
{
    public GameObject esfera;   // arrastrar desde el inspector
    public float speed = 3f;    // velocidad del cubo
    public float moveSpeed = 5f; // velocidad de movimiento de la esfera

    void Update()
    {
        if (esfera == null) return;

        // ---- MOVIMIENTO DE LA ESFERA CON WASD ----
        float moveX = Input.GetAxis("Horizontal"); // A (-1) - D (+1)
        float moveZ = Input.GetAxis("Vertical");   // S (-1) - W (+1)

        Vector3 movimientoEsfera = new Vector3(moveX, 0, moveZ) * moveSpeed * Time.deltaTime;
        esfera.transform.Translate(movimientoEsfera, Space.World);

        // ---- MOVIMIENTO DEL CUBO ----

        // Posiciones
        Vector3 posicionCubo = transform.position;
        Vector3 posicionEsfera = esfera.transform.position;

        // Mantener altura del cubo
        posicionEsfera.y = posicionCubo.y;

        // Hacer que el cubo mire hacia la esfera
        transform.LookAt(posicionEsfera);

        // Avanzar hacia la esfera (en su eje Z local)
        transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.Self);
    }
}
