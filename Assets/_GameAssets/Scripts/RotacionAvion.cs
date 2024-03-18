using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RotacionAvion : MonoBehaviour
{
    public float velocidadRotacion;
    
    private float z;
    void Update() {
        z = Input.GetAxis("Horizontal");
        transform.localEulerAngles = new Vector3(
            transform.localEulerAngles.x,
            transform.localEulerAngles.y,
            z * velocidadRotacion * -1
        );
    }
}
