using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float upperLimit = 20f;
    private float lowerLimit = -10f;

    private void Update()
    {
        //límite inferior -> animales no alimentados
        if(transform.position.z < lowerLimit)
        {
            Destroy(gameObject);
            //mecánica GAME OVER
            Debug.Log("GAME OVER");
            Time.timeScale = 0;
        }

        //límite superior -> la bala ha fallado
        if(transform.position.z > upperLimit)
        {
            Destroy(gameObject);
        }
    }
}
