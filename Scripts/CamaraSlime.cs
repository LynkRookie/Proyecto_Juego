using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraSlime : MonoBehaviour
{
     public GameObject Slime_Toxico;
    public float Velocidad_Suave = 0.125f; // Velocidad de suavizado
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /* Vector3 position = transform.position;
        position.x = Slime_Toxico.transform.position.x;
        position.y = Slime_Toxico.transform.position.y;
        transform.position = position;*/

        Vector3 desiredPosition = Slime_Toxico.transform.position; 
        // La posición a la que queremos que la cámara se mueva
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, 
        desiredPosition, Velocidad_Suave); // Movimiento suavizado

        transform.position = smoothedPosition; 
        // Aplica el movimiento suavizado a la cámara
    }
}
