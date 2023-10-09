using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class heliUi : MonoBehaviour
{
    public Slider slider1;
    public Slider slider2;
    [SerializeField] private GameObject helicopter;
    private helicopter heliscript;

    // Start is called before the first frame update
    void Start()
    {
        heliscript = helicopter.GetComponent<helicopter>();
    }

    // Update is called once per frame
    void Update()
    {
        heliscript.speed = slider1.value;
        heliscript.height = slider2.value;
    }
}
