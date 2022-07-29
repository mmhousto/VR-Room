using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flicker : MonoBehaviour
{

    Light candleLight;
    ToggleLight toggleLight;

    // Start is called before the first frame update
    void Start()
    {
        candleLight = GetComponent<Light>();
        toggleLight = GetComponent<ToggleLight>();
        InvokeRepeating(nameof(ChangeLightLevel), 0.1f, 0.25f);
    }

    void ChangeLightLevel()
    {
        if (toggleLight.isOn)
            candleLight.intensity = Random.Range(0.004f, 0.006f);
    }
}
