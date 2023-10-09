using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class platscript : MonoBehaviour
{
    public Slider slider1;
    public Slider slider2;
    [SerializeField] private GameObject plat;
    private rotateplatform platScript;

    // Start is called before the first frame update
    void Start()
    {
        platScript = plat.GetComponent<rotateplatform>();
    }

    // Update is called once per frame
    void Update()
    {
        platScript.speed = slider1.value;
        platScript.x = (int)slider2.value;
    }
}
