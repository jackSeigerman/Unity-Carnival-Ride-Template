using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class droneUi : MonoBehaviour
{
    public Slider speedSlider;
    public Slider horizSlider;
    public Slider pitchSlider;
    public Slider yawSlider;
    public Slider vertSlider;

    public GameObject drone;

    private droneCamera droneCamera2;

    float a;
    float b;
    float c;
    float d;
    float e;



    // Start is called before the first frame update
    void Start()
    {
        droneCamera2 = drone.GetComponent<droneCamera>();
        a = pitchSlider.value;
        b = yawSlider.value;
        c = speedSlider.value;
        d = horizSlider.value;
        e = vertSlider.value;
}

    // Update is called once per frame
    void Update()
    {
        if (pitchSlider.value > a){
            droneCamera2.pitch = pitchSlider.value;
            a = pitchSlider.value;
        }
        if (pitchSlider.value < a)
        {
            droneCamera2.pitch = pitchSlider.value;
            a = pitchSlider.value;
        }
        if (yawSlider.value > b)
        {
            droneCamera2.yaw = yawSlider.value;
            b = yawSlider.value;
        }
        if (yawSlider.value < b)
        {
            droneCamera2.yaw = yawSlider.value;
            b = yawSlider.value;
        }
        if (speedSlider.value > c)
        {
            droneCamera2.speed = speedSlider.value;
            c = speedSlider.value;
        }
        if (speedSlider.value < c)
        {
            droneCamera2.speed = speedSlider.value;
            c = speedSlider.value;
        }
        if (horizSlider.value > d)
        {
            droneCamera2.horizontalInput = horizSlider.value;
            d = horizSlider.value;
        }
        if (horizSlider.value < d)
        {
            droneCamera2.horizontalInput = horizSlider.value;
            d = horizSlider.value;
        }
        if (vertSlider.value > e)
        {
            droneCamera2.verticalInput = vertSlider.value;
            e = vertSlider.value;
        }
        if (vertSlider.value < e)
        {
            droneCamera2.verticalInput = vertSlider.value;
            e = vertSlider.value;
        }

    }
}
