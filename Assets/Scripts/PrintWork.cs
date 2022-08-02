using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintWork : MonoBehaviour
{

    public Transform newSpawnLocation;
    public Transform artSpawnPoint;
     
    public void PrintArt()
    {
        GameObject[] artWorkObjects = GameObject.FindGameObjectsWithTag("Trail");
        GameObject art = new GameObject("ArtWork");
        art.transform.position = artSpawnPoint.position;

        for (int i = 0; i < artWorkObjects.Length; i++)
        {
            artWorkObjects[i].transform.parent = art.transform;
        }

        var newPosition = newSpawnLocation.position;
        var newRotation = newSpawnLocation.rotation;
        
        var trailRenderers = art.GetComponentsInChildren<TrailRenderer>();
        foreach (var trailRenderer in trailRenderers)
        {
            var offset = newPosition - trailRenderer.transform.position;
            var positionCount = trailRenderer.positionCount;
            for (var i = 0; i < positionCount; i++)
                trailRenderer.SetPosition(i, trailRenderer.GetPosition(i) + offset);
        }

        art.transform.localScale *= 0.5f;
        art.transform.position = newPosition;

    }


    private void RepositionTrail()
    {
        
    }

}
