using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float upperLimit = 20f;
    private float lowerLimit = -10f;

    private void Update()
    {
        //l�mite inferior -> animales no alimentados
        if(transform.position.z < lowerLimit)
        {
            Destroy(gameObject);
            //mec�nica GAME OVER
            Debug.Log("GAME OVER");
            Time.timeScale = 0;
        }

        //l�mite superior -> la bala ha fallado
        if(transform.position.z > upperLimit)
        {
            Destroy(gameObject);
        }
    }
}
