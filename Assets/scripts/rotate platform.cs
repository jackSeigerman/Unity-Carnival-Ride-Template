using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class rotateplatform : MonoBehaviour
{
    [SerializeField] private int speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, speed*Time.deltaTime);
    }
}
