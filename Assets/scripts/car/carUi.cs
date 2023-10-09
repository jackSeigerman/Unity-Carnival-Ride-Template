using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class carUi: MonoBehaviour
{
    public Slider slider1;
    public Slider slider2;
    public Slider slider3;
    [SerializeField] private GameObject car;
    private car carScript;

    // Start is called before the first frame update
    void Start()
    {
        carScript = car.GetComponent<car>();
    }

    // Update is called once per frame
    void Update()
    {
        carScript.speed = slider1.value;
        carScript.horizSpeed = slider2.value;
        carScript.height = slider3.value;
    }
}
