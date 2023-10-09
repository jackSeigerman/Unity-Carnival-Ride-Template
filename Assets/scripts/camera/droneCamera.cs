using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class droneCamera : MonoBehaviour
{
    public CameraSwitcher cameraSwitcher;
    public float pitch=0;
    public float yaw=0;
    public GameObject crashmenu;
    public float speed = 10f;
    public float sens = 0.5f;
    public float horizontalInput = 0f;
    public float verticalInput = 0f;
    [SerializeField] private Canvas canvas;
    // Start is called before the first frame update
    void Start()
    {
        cameraSwitcher = GameObject.FindObjectOfType<CameraSwitcher>();
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        crashmenu.SetActive(true);

        StartCoroutine(Coroutine1());

    }
    void Update()
    {
        if (cameraSwitcher != null)
        {
            int indexToCheck = 1; 

            bool isActiveCameraAtIndex = cameraSwitcher.IsActiveCameraAtIndex(indexToCheck);

            if (isActiveCameraAtIndex)
            {
                canvas.gameObject.SetActive(true);
                    bool pitchInputup = Input.GetKey(KeyCode.I);
                    bool pitchInputdown = Input.GetKey(KeyCode.K);
                    bool yawInputup = Input.GetKey(KeyCode.L);
                    bool yawInputdown = Input.GetKey(KeyCode.J);
                    if (pitchInputup)
                    {
                        pitch+=1;
                    }
                    if (pitchInputdown)
                    {
                        pitch-=1;
                    }
                    if (yawInputup)
                    {
                        yaw+=1;

                    }
                    if (yawInputdown)
                    {
                        yaw-=1;
                    }


                    transform.rotation = Quaternion.Euler(pitch*sens, yaw*sens, 0f);

                    if(Mathf.Abs(Input.GetAxis("Horizontal"))>0.001f)
                    {
                        horizontalInput = Input.GetAxis("Horizontal");
                    }
                    if (Mathf.Abs(Input.GetAxis("Vertical")) > 0.001f)
                    {
                        verticalInput = Input.GetAxis("Vertical");
                    }


                    Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput).normalized;
                    Vector3 newPosition = (transform.forward * verticalInput + transform.right * horizontalInput);
                    transform.position += newPosition * Time.deltaTime * speed;

                    //transform.position -= new Vector3(0, transform.position.y-5, 0);
                transform.position = new Vector3(Mathf.Clamp(transform.position.x, -Mathf.Infinity, Mathf.Infinity), Mathf.Clamp(transform.position.y, 2.7f, Mathf.Infinity), Mathf.Clamp(transform.position.z, -Mathf.Infinity, Mathf.Infinity));
            }
            else
            {
                canvas.gameObject.SetActive(false);
            }

       
    }
 
    }
    IEnumerator Coroutine1()
    {

        yield return new WaitForSeconds(2);
        transform.position = new Vector3(17.1399994f, 8f, -15.5299997f);
        gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
        crashmenu.SetActive(false);


    }
}