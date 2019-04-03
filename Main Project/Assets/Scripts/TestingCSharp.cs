using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingCSharp : MonoBehaviour
{

    public Light myLight;
    [SerializeField] private Light mySecondLight;
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            SwitchTheLight(myLight);
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            SwitchTheColor(myLight);
        }
    }


    void SwitchTheLight(Light light)
    {
        light.enabled = !light.enabled;
    }

    void SwitchTheColor(Light light)
    {
        light.color = Random.ColorHSV();
    }
}
