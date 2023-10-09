using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mainUi : MonoBehaviour
{
    public Slider pitchSlider;
    public Slider yawSlider;
    public Slider speedSlider;
    public GameObject MainCamera;
    private defaultCamera main;
    float a;
    float b;



    // Start is called before the first frame update
    void Start()
    {
        main = MainCamera.GetComponent<defaultCamera>();
        a = pitchSlider.value;
        b = yawSlider.value;

    }

    // Update is called once per frame
    void Update()
    {
        main.speed = speedSlider.value;
        
        if (pitchSlider.value > a)
        {
            main.pitch = pitchSlider.value;
            a = pitchSlider.value;
        }
        if (pitchSlider.value < a)
        {
            main.pitch = pitchSlider.value;
            a = pitchSlider.value;
        }
        if (yawSlider.value > b)
        {
            main.yaw = yawSlider.value;
            b = yawSlider.value;
        }
        if (yawSlider.value < b)
        {
            main.yaw = yawSlider.value;
            b = yawSlider.value;
        }


    }
}
