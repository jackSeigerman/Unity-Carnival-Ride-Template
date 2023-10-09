using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ground : MonoBehaviour
{
    [SerializeField] private GameObject invismenu;
    [SerializeField] private GameObject platmenu;
    private bool debounce = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!platmenu.activeSelf)
        {
            if (invismenu.activeSelf)
            {
                if (debounce)
                {
                    debounce = false;
                    gameObject.GetComponent<AudioSource>().Play();
                }
                return;
            }
            debounce = true;
        }
    }
}
