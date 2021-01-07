using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Spawner : MonoBehaviour
{
    public GameObject [] objectToSpawnArray;
    public GameObject bomb;
    public Transform[] spawnLocations;

    public float minWait = 0.3f;
    public float maxWait = 1f;
    public float minForce = 12f;
    public float maxForce = 17f;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnFruits());
    }

    private IEnumerator SpawnFruits()
    {
        while (true)
        {
            
            yield return new WaitForSeconds(Random.Range(minWait, maxWait)); //spawn intervals using minWait and maxWait.
            
            //Debug.Log("Fruits get spawned");
            
            var spawnTransform= spawnLocations[Random.Range(0,spawnLocations.Length)];//assign spawn location of fruit to list of spawnLocations index via random class.

            GameObject objectsToSpawn = null; // create a null game object that will get assigned a fruit via random value- "randomValue"
            
            var randomValueInt = Random.Range(0, 100);

            if (randomValueInt < 10)
            {
                objectsToSpawn = bomb;
            }
            else
            {
                objectsToSpawn = objectToSpawnArray[Random.Range(0,objectToSpawnArray.Length)];
            }
            
            var fruitSpawned = Instantiate(objectsToSpawn, spawnTransform.position,spawnTransform.rotation);//instantiate  fruitToSpawn at t. (which is randomly selected in line 27.
            fruitSpawned.GetComponent<Rigidbody2D>().AddForce(spawnTransform.transform.up * Random.Range(minForce,maxForce),ForceMode2D.Impulse); //give impulse power up. T's transform, and not just balls transform - we want the angle of the T, which is the spawnLocation's angle.. also multiply by random range.
            
            //Debug.Log("Fruit created");
            
            Destroy(fruitSpawned,3);//destroy the spawnedFruit after x seconds.
        }
    }
}
