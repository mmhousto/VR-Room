using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintWork : MonoBehaviour
{

    public Transform spawnLocation;
     
    public void PrintArt()
    {
        GameObject[] artWorkObjects = GameObject.FindGameObjectsWithTag("Trail");
        GameObject art = new GameObject("ArtWork");
        for (int i = 0; i < artWorkObjects.Length; i++)
        {
            artWorkObjects[i].transform.parent = art.transform;
        }
        art.transform.localScale *= 0.5f;
        art.transform.localPosition = spawnLocation.position;

    }

}
