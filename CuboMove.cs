using UnityEngine;

public class CuboMove : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        float x = 0f;
        float z = 0f;

        if (Input.GetKey(KeyCode.LeftArrow)) x = -1f;
        if (Input.GetKey(KeyCode.RightArrow)) x = 1f;
        if (Input.GetKey(KeyCode.UpArrow)) z = 1f;
        if (Input.GetKey(KeyCode.DownArrow)) z = -1f;

        Vector3 movimiento = new Vector3(x, 0f, z);
        transform.Translate(movimiento * speed * Time.deltaTime, Space.World);
    }
}
