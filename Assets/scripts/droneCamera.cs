using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class droneCamera : MonoBehaviour
{
    private CameraSwitcher cameraSwitcher;
    private float pitch=0;
    private float yaw=0;
    [SerializeField] private int speed = 10;
    [SerializeField]
    private float sens = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        cameraSwitcher = GameObject.FindObjectOfType<CameraSwitcher>();
    }

    // Update is called once per frame
    void Update()
    {
        if (cameraSwitcher != null)
        {
            int indexToCheck = 1; 

            bool isActiveCameraAtIndex = cameraSwitcher.IsActiveCameraAtIndex(indexToCheck);

            if (isActiveCameraAtIndex)
            {
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

                    float horizontalInput = Input.GetAxis("Horizontal");
                    float verticalInput = Input.GetAxis("Vertical");
                    Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput).normalized;
                    Vector3 newPosition = (transform.forward * verticalInput + transform.right * horizontalInput);
                    transform.position += newPosition * Time.deltaTime * speed;

                    //transform.position -= new Vector3(0, transform.position.y-5, 0);
                transform.position = new Vector3(Mathf.Clamp(transform.position.x, -20, 20), Mathf.Clamp(transform.position.y, 2.7f, 15), Mathf.Clamp(transform.position.z,-20,20));
            }
            else
            {
                Debug.Log("not active");
            }

       
    }
}
}