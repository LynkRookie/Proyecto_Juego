using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraSlime2 : MonoBehaviour
{
    public GameObject Slime_Toxico;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;
        position.x = Slime_Toxico.transform.position.x;
        position.y = Slime_Toxico.transform.position.y;
        transform.position = position;
    }
}
