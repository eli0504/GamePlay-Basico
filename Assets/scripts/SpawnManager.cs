using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs; //ARRAY DE ANIMALES
    private int animalIndex;  //índice del array de animales

    private float spawnRangeX = 14f;
    private float spawnPosZ = 15f;

    private float startDelay = 1.5f;
    private float spawnInterval = 2f;

    private void Start()  
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);  //llama periódicamente a la función SpawnRandomAnimal
    }

    private void SpawnRandomAnimal()  //funcion que hace aparecer a un animal aleatorio en una posicion aleatoria 
    {
        animalIndex = Random.Range(0, animalPrefabs.Length);  //generamos indice aleatorio 
        Instantiate(animalPrefabs[animalIndex], RandomSpawnPos(), animalPrefabs[animalIndex].transform.rotation);
    }


    private Vector3 RandomSpawnPos()  //fucion que genera un vector aleatorio
    {
        float randomX = Random.Range(-spawnRangeX, spawnRangeX);  //generamos numero aleatorio para coordenada x
        return new Vector3(randomX, 0, spawnPosZ);

    }
}
