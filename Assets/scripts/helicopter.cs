using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class helicopter : MonoBehaviour
{
    [SerializeField] private int height = 3;
    [SerializeField] private int speed = 1;
    private float active = 1;
    private bool up = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (active <= height)
        {
            up = true;

        }
        else
        {
            up = false;

        }
        if (up)
        {
            active += 1;

        }

        else
        {
            active -= 1;
            
        }

        Debug.Log(active);
        transform.position += new Vector3(0, active, 0) * Time.deltaTime * speed;

    }
}

