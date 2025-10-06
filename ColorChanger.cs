using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    // Vector que representa el color (R, G, B)
    private Vector3 colorVector;

    // Cuántos frames deben pasar antes de cambiar el color
    public int framesToWait = 120;

    // Contador de frames
    private int frameCount = 0;

    // Referencia al Renderer del objeto
    private Renderer objRenderer;

    void Start()
    {
        // Obtener el Renderer del objeto al que está asociado este script
        objRenderer = GetComponent<Renderer>();

        // Inicializar el vector con valores aleatorios entre 0 y 1
        colorVector = new Vector3(Random.value, Random.value, Random.value);

        // Aplicar el color inicial
        objRenderer.material.color = new Color(colorVector.x, colorVector.y, colorVector.z);
    }

    void Update()
    {
        // Incrementamos el contador de frames
        frameCount++;

        // Cuando pasen "framesToWait" frames...
        if (frameCount >= framesToWait)
        {
            // Elegimos una componente aleatoria (0 = R, 1 = G, 2 = B)
            int randomIndex = Random.Range(0, 3);

            // Cambiamos solo esa componente a un nuevo valor aleatorio
            if (randomIndex == 0) colorVector.x = Random.value;
            else if (randomIndex == 1) colorVector.y = Random.value;
            else colorVector.z = Random.value;

            // Aplicamos el nuevo color al material
            objRenderer.material.color = new Color(colorVector.x, colorVector.y, colorVector.z);

            // Reiniciamos el contador
            frameCount = 0;
        }
    }
}
