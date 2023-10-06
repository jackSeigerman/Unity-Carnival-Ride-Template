using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera[] cameras;
    private int currentCameraIndex = 0;

    void Start()
    {
 
        ActivateCamera(currentCameraIndex);
    }

    void Update()
    {
 
        if (Input.GetKeyDown(KeyCode.C))
        {
            SwitchToNextCamera();
        }
    }
    public bool IsActiveCameraAtIndex(int indexToCheck)
    {
        if (indexToCheck >= 0 && indexToCheck < cameras.Length)
        {
            return cameras[currentCameraIndex] == cameras[indexToCheck];
        }
        return false;
    }
    void ActivateCamera(int index)
    {
    
        foreach (Camera cam in cameras)
        {
            cam.gameObject.SetActive(false);
        }

 
        cameras[index].gameObject.SetActive(true);
    }
    public Camera GetCurrentCamera()
    {
        return cameras[currentCameraIndex];
    }

    public void SwitchToNextCamera()
    {
     
        cameras[currentCameraIndex].gameObject.SetActive(false);

      
        currentCameraIndex = (currentCameraIndex + 1) % cameras.Length;

    
        ActivateCamera(currentCameraIndex);
    }
}
