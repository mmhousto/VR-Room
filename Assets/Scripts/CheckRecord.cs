using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckRecord : MonoBehaviour
{
    public Transform hand;
    public RotateObject record;
    public int currentRecord = 0;

    // Git Gud
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BlueRecord"))
        {
            currentRecord = 1;
        } else if (other.CompareTag("RedRecord"))
        {
            currentRecord = 2;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("BlueRecord") || other.CompareTag("RedRecord"))
        {
            currentRecord = 0;
        }
    }

    public void PlayRecord()
    {
        GetComponent<PlaySoundsFromList>().PlayAtIndex(currentRecord - 1);
        record.enabled = true;
        hand.localRotation = Quaternion.Euler(new Vector3(357f, 45f, 0f));
    }

    public void StopRotating()
    {
        record.enabled = false;
        hand.localRotation = Quaternion.Euler(new Vector3(0f, 0f, 0f));
    }

}
