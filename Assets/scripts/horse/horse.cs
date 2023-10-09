using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class horse : MonoBehaviour
{
    public int x = 1;
    public float speed = 10;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void fUpdate()
    {
        transform.Rotate(Vector3.up*x, speed * Time.deltaTime);
    }
}
