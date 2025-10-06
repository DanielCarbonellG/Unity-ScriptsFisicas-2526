using UnityEngine;

public class VectorInfo : MonoBehaviour
{
    // Los dos vectores que podrás configurar desde el Inspector
    public Vector3 vectorA;
    public Vector3 vectorB;

    // Variables para mostrar los resultados en el Inspector
    [Header("Resultados")]
    public float magnitudA;
    public float magnitudB;
    public float anguloEntre;
    public float distancia;
    public string vectorMasAlto;

    void Start()
    {
        // Calcular la magnitud de cada vector
        magnitudA = vectorA.magnitude;
        magnitudB = vectorB.magnitude;

        // Calcular el ángulo entre ambos vectores
        anguloEntre = Vector3.Angle(vectorA, vectorB);

        // Calcular la distancia entre ellos
        distancia = Vector3.Distance(vectorA, vectorB);

        // Comparar cuál tiene mayor altura (componente Y)
        if (vectorA.y > vectorB.y)
            vectorMasAlto = "El Vector A está más alto.";
        else if (vectorA.y < vectorB.y)
            vectorMasAlto = "El Vector B está más alto.";
        else
            vectorMasAlto = "Ambos vectores tienen la misma altura.";

        // Mostrar resultados en la consola
        Debug.Log($"Magnitud de A: {magnitudA}");
        Debug.Log($"Magnitud de B: {magnitudB}");
        Debug.Log($"Ángulo entre A y B: {anguloEntre} grados");
        Debug.Log($"Distancia entre A y B: {distancia}");
        Debug.Log(vectorMasAlto);
    }
}
