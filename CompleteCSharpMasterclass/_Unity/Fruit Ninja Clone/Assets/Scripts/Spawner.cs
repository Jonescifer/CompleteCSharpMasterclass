using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject fruitToSpawn;
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
            //spawn intervals
            yield return new WaitForSeconds(Random.Range(minWait, maxWait));
            
            //assign spawn location of fruit to list of spawnLocations index via random class.
            Transform t = spawnLocations[Random.Range(0,spawnLocations.Length)];

            //instantiate  fruitToSpawn at t. (which is randomly selected in line 27.
            GameObject fruitSpawned = Instantiate(fruitToSpawn, t.position,t.rotation);
            
            //give impulse power up. T's transform, and not just balls transform - we want the angle of the T, which is the spawnLocation's angle..
            fruitSpawned.GetComponent<Rigidbody2D>().AddForce(t.transform.up*Random.Range(minForce,maxForce),ForceMode2D.Impulse);
            
            //Debug.Log("Fruit created");
            
            Destroy(fruitSpawned,5);

        }
    }
}
