using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class defaultCamera : MonoBehaviour
{

    public float pitch=0;
    public float yaw=0;
    public float speed = 10;
    [SerializeField] private float sens = 0.5f;
    public GameObject helimenu;
    public GameObject maincam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (maincam.activeSelf)
        {
            helimenu.SetActive(true);
            bool pitchInputup = Input.GetKey(KeyCode.I);
            bool pitchInputdown = Input.GetKey(KeyCode.K);
            bool yawInputup = Input.GetKey(KeyCode.L);
            bool yawInputdown = Input.GetKey(KeyCode.J);
            if (pitchInputup)
            {
                pitch += 1;
            }
            if (pitchInputdown)
            {
                pitch -= 1;
            }
            if (yawInputup)
            {
                yaw += 1;

            }
            if (yawInputdown)
            {
                yaw -= 1;
            }

            if (pitch >= 80 / sens)
            {
                pitch -= 1;
            }

            else if (pitch <= -80 / sens)
            {
                pitch += 1;
            }

            transform.rotation = Quaternion.Euler(pitch * sens, yaw * sens, 0f);

            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");
            Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput).normalized;
            Vector3 newPosition = (transform.forward * verticalInput + transform.right * horizontalInput);
            transform.position += newPosition * Time.deltaTime * speed;

            //transform.position -= new Vector3(0, transform.position.y-5, 0);
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, -20, 20), 5, Mathf.Clamp(transform.position.z, -20, 20));
        }

    }
    void OnDisable()
    {
        helimenu.SetActive(false);
    }
}


