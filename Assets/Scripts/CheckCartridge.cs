using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCartridge : MonoBehaviour
{
    public int currentCartridge = 0;
    public PlayVideo playVideo;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Rampage"))
        {
            currentCartridge = 1;
        }
        else if (other.CompareTag("DK"))
        {
            currentCartridge = 2;
        }
        else if (other.CompareTag("Mario"))
        {
            currentCartridge = 3;
        }
        else if (other.CompareTag("Pokemon"))
        {
            currentCartridge = 4;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("DK") || other.CompareTag("Mario") || other.CompareTag("Rampage") || other.CompareTag("Pokemon"))
        {
            currentCartridge = 0;
            playVideo.Stop();
        }
    }

    public void PlayThisVideo()
    {
        if(currentCartridge == 0)
        {
            playVideo.Stop();
        }
        else
        {
            playVideo.PlayAtIndex(currentCartridge-1);
        }
    }
}
