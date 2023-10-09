using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class heliRotor : MonoBehaviour
{
    [SerializeField] private Canvas canvas;
    [SerializeField] private int speed = 10;
    [SerializeField] private GameObject invismenu;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (invismenu.activeSelf)
        {
            return;
        }
        if (canvas.isActiveAndEnabled)
        {
            return;
        }
        transform.Rotate(Vector3.up, speed * Time.deltaTime);
    }
}
