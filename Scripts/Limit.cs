using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limit : MonoBehaviour
{
   public Transform limite; // Referencia al objeto que representa el límite
    public float anchoLimite; // Ancho del límite
    public float alturaLimite; // Altura del límite

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 posicionCamara = transform.position;
        Vector3 posicionLimite = limite.position;
        
        // Limitar la posición de la cámara dentro del límite
        posicionCamara.x = Mathf.Clamp(posicionCamara.x, posicionLimite.x - anchoLimite, posicionLimite.x + anchoLimite);
        posicionCamara.y = Mathf.Clamp(posicionCamara.y, posicionLimite.y - alturaLimite, posicionLimite.y + alturaLimite);
        
        transform.position = posicionCamara; 
        // Aplicar la nueva posición limitada a la cámara
    }
}
