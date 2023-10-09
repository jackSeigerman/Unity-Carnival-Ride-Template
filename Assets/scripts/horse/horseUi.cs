using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class horseUi : MonoBehaviour
{
    public Slider slider1;
    public Slider slider2;
    public Slider slider3;
    [SerializeField] private GameObject horse;
    [SerializeField] private GameObject horseModel;
    private horse horseScript;
    private horseOffset offsetScript;

    // Start is called before the first frame update
    void Start()
    {
        horseScript = horse.GetComponent<horse>();
        offsetScript = horseModel.GetComponent<horseOffset>();
    }

    // Update is called once per frame
    void Update()
    {
        horseScript.speed = slider1.value;
        horseScript.x = (int)slider3.value;
        offsetScript.offset = slider2.value;
    }
}
