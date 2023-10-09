using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class helicopter : MonoBehaviour
{
    public CameraSwitcher cameraSwitcher;
    [SerializeField] private string direction = "up";
    [SerializeField] public float speed = 1;
    [SerializeField] public float height = 6;
    [SerializeField] private Canvas canvas;
    [SerializeField] private GameObject helimenu;
    private bool debounce = true;
    [SerializeField] private GameObject invismenu;
    // Start is called before the first frame updateww
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
        
    {
        if (cameraSwitcher != null)
        {
            int indexToCheck = 2;

            bool isActiveCameraAtIndex = cameraSwitcher.IsActiveCameraAtIndex(indexToCheck);

            if (isActiveCameraAtIndex)
            {
                helimenu.SetActive(true);
            }
            else {
                helimenu.SetActive(false);
            }
            
        }

        if (invismenu.activeSelf)

        {
            return;
        }
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
        if (direction == "up")
        {
            if (gameObject.transform.position.y > height)
            {
                direction = "down";
                gameObject.transform.position += new Vector3(0, -1, 0) * speed * (Time.deltaTime);

            }
            else
            {
                gameObject.transform.position += new Vector3(0, 1, 0) * speed * (Time.deltaTime);
            }
        }
        if (direction == "down")
        {
            if (gameObject.transform.position.y < 2.75)
            {
                direction = "up";
                gameObject.transform.position += new Vector3(0, 1, 0) * speed * (Time.deltaTime);
            }
            else
            {
                gameObject.transform.position += new Vector3(0, -1, 0) * speed * (Time.deltaTime);
            }
        }

        
    }

}