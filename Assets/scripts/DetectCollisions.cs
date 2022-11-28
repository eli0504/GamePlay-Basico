using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject); //destruye el proyectil
        Destroy(other.gameObject); //destruye el animal con el que colisiono
    }
}
