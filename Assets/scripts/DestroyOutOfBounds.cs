using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float upperLimit = 20f;
    public float lowerLimit = -10f;

    private void Update()
    {
        //l�mite inferior -> animales no alimentados
        if(transform.position.z < lowerLimit)
        {
            Destroy(gameObject);
        }

        //l�mite superior -> la bala ha fallado
        if(transform.position.z > upperLimit)
        {
            Destroy(gameObject);
        }
    }
}
