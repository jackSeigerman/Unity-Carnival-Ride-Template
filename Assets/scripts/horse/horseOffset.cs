using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class horseOffset : MonoBehaviour
{
    public Canvas canvas;
    public CameraSwitcher cameraSwitcher;
    public float offset = 0;
    public bool debounce = true;
    public horse horseScript;
    [SerializeField] private GameObject invismenu;
    [SerializeField] private GameObject horsemenu;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (cameraSwitcher != null)
        {
            int indexToCheck = 3;

            bool isActiveCameraAtIndex = cameraSwitcher.IsActiveCameraAtIndex(indexToCheck);

            if (isActiveCameraAtIndex)
            {
                horsemenu.SetActive(true);
            }
            else
            {
                horsemenu.SetActive(false);
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
        transform.localPosition = new Vector3(0f, 0f, offset);
        horseScript.fUpdate();
    }
}

