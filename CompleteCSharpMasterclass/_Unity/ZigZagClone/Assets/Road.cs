using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

public class Road : MonoBehaviour
{
    public GameObject roadPrefab;
    public Vector3 lastBlockPosition;
    public float offset = 0.707f;
    private int _roadCount = 0;

    public void StartBuilding()
    {
        InvokeRepeating(nameof(CreateNewRoadPart),1,0.5f);
    }


    public void CreateNewRoadPart()
    {
        //Debug.Log("Created new road block!");
        
        Vector3 spawnPos;

        float chance = Random.Range(0, 100);
        if (chance < 50)
        {
            spawnPos = new Vector3(lastBlockPosition.x + offset, lastBlockPosition.y, lastBlockPosition.z+offset);
        }
        else
        {
            spawnPos = new Vector3(lastBlockPosition.x - offset, lastBlockPosition.y, lastBlockPosition.z + offset);
        }

        GameObject g = Instantiate(roadPrefab, spawnPos, Quaternion.Euler(0,45,0));
        
        //update last position to new postision of the latest spawned block!
        lastBlockPosition = g.transform.position;
        //increase roadCount by one
        _roadCount++;
        
        if (_roadCount % 5 == 0)
        {
            g.transform.GetChild(0).gameObject.SetActive(true);
        }
    }
    
}
