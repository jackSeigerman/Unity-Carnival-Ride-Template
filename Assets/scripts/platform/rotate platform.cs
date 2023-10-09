using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class rotateplatform : MonoBehaviour
{
    public GameObject invismenu;
    public float speed = 10;
    public int x=1;
    public Canvas canvas;
    private bool debounce = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    // Update is called once per frame
    void Update()
    {
        if (canvas.isActiveAndEnabled)
        {
            if (debounce)
            {
                debounce = false;
                gameObject.GetComponent<AudioSource>().Play();
            }
            return;
        }
        debounce = true;



        if (invismenu != null && invismenu.activeSelf)
        {
            return;
        }
        else
        {
            transform.Rotate(Vector3.up*x, speed * Time.deltaTime);
        }
    }

}
