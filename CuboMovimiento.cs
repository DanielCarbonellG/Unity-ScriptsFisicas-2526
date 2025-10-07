using UnityEngine;

public class CuboMovimiento : MonoBehaviour
{
    // Dirección del movimiento editable desde el Inspector
    public Vector3 moveDirection = new Vector3(1f, 0f, 0f);
    
    // Velocidad editable desde el Inspector
    public float speed = 2f;

    void Start()
    {
        // Inicialmente la posición en Y debe ser 0
        Vector3 pos = transform.position;
        pos.y = 0.5f;
        transform.position = pos;
    }

    void Update()
    {
        // Movemos el cubo cada frame
        transform.Translate(moveDirection * speed * Time.deltaTime, Space.World);
    }

}
