using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotatePedestal : MonoBehaviour
{

    public Transform pedestal;

    private Slider slider;

    void Start()
    {
        slider = GetComponent<Slider>();   
    }

    public void Rotate(System.Single vol)
    {
        pedestal.rotation = Quaternion.Euler(0, vol, 0);
    }

}
