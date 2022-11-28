using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 10f;     //velocidad de player
    private float xRange = 15f;    //límite pantalla horizontal

    public GameObject projectilePrefab;
   
    private float horizontalInput;

    private void Update()
    {
        //movimiento horizontal de player
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);
        PlayerInBounds();  //llamamos a la funcion (mantiene al player en la pantalla)

        if (Input.GetKeyDown(KeyCode.Space))  //mecánica del disparo
        {
            FireProjectile();
        }
    }

    private void PlayerInBounds()  
    {
        Vector3 pos = transform.position;
        if(pos.x < -xRange)
        {
            transform.position = new Vector3(-xRange, pos.y, pos.z);
        }

        if(pos.x > xRange)
        {
            transform.position = new Vector3(xRange, pos.y, pos.z);
        }
    }

    private void FireProjectile() 
    {
        Instantiate(projectilePrefab, transform.position, Quaternion.identity);
    }
}
