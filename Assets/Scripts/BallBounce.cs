using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : MonoBehaviour
{

    AudioSource audioSource;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(rb.linearVelocity.magnitude);
        audioSource.PlayOneShot(audioSource.clip, rb.linearVelocity.magnitude);
    }
}
