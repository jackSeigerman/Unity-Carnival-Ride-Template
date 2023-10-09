using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycaster : MonoBehaviour
{
    [SerializeField] private GameObject[] obj;
    [SerializeField] private GameObject helimenu;
    [SerializeField] private GameObject horsemenu;
    [SerializeField] private GameObject carmenu;
    [SerializeField] private GameObject invismenu;
    [SerializeField] private GameObject platformsmenu;
    public bool debounce = false;




    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Camera[] cameras = Camera.allCameras;

            foreach (Camera camera in cameras)
            {


                Ray ray = camera.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                foreach (GameObject gameObject in obj)
                {

                    if (Physics.Raycast(ray, out hit))
                    {

                        if (hit.collider.gameObject == gameObject)
                        {
                            horsemenu.SetActive(false);
                            helimenu.SetActive(false);
                            carmenu.SetActive(false);
                            invismenu.SetActive(false);
                            platformsmenu.SetActive(false);


                            if (hit.collider.gameObject.GetComponent<helicopter>())
                            {
                                helimenu.SetActive(true);
                            }
                            if (hit.collider.gameObject.GetComponent<horseOffset>())
                            {
                                horsemenu.SetActive(true);
                            }
                            if (hit.collider.gameObject.GetComponent<car>())
                            {
                                carmenu.SetActive(true);
                            }
                            if (hit.collider.gameObject.GetComponent<ground>())
                            {
                                StartCoroutine(Coroutine1());
                                if (hit.collider.gameObject.GetComponent<ground>()&&debounce)
                                {
                                    invismenu.SetActive(true);
                                }
                            }
                            if (hit.collider.gameObject.GetComponent<rotateplatform>())
                             {
                                platformsmenu.SetActive(true);
                                invismenu.SetActive(true);
                                

                             }

                            
                        }
                    }
                }
            }
        }

    }
    IEnumerator Coroutine1()
    {

        yield return new WaitForSeconds(0.2f);
        debounce = true;
        StartCoroutine(Coroutine2());


    }
    IEnumerator Coroutine2()
    {

        yield return new WaitForSeconds(1);
        debounce = false;


    }
}
