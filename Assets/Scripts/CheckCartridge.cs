using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CheckCartridge : MonoBehaviour
{
    public int currentCartridge = 0;
    public PlayVideo playVideo;
    private bool cartridgeAdded;
    private bool cartridgeComplete;
    public TextMeshProUGUI contextPrompt;
    private string startText;

    private void Start()
    {
        startText = contextPrompt.text;
    }

    private void Update()
    {
        if (cartridgeComplete) { contextPrompt.transform.parent.gameObject.SetActive(false); }
        else if(cartridgeAdded == true)
        {
            contextPrompt.text = "Grab controller and press play";
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Rampage"))
        {
            currentCartridge = 1;
            cartridgeAdded = true;
        }
        else if (other.CompareTag("DK"))
        {
            currentCartridge = 2;
            cartridgeAdded = true;
        }
        else if (other.CompareTag("Mario"))
        {
            currentCartridge = 3;
            cartridgeAdded = true;
        }
        else if (other.CompareTag("Pokemon"))
        {
            currentCartridge = 4;
            cartridgeAdded = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("DK") || other.CompareTag("Mario") || other.CompareTag("Rampage") || other.CompareTag("Pokemon"))
        {
            cartridgeAdded = false;
            contextPrompt.text = startText;
            currentCartridge = 0;
            playVideo.Stop();
        }
    }

    public void CompleteContext()
    {
        cartridgeComplete = true;
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
