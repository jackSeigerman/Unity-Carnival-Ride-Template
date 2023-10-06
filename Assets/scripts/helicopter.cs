using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class helicopter : MonoBehaviour
{
    [SerializeField] private string direction = "up";
    [SerializeField] private float speed = 1;
    [SerializeField] private int height = 6;
    // Start is called before the first frame updateww
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
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
        Debug.Log(direction);
    }
}