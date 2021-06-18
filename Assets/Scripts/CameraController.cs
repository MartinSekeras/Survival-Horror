using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject CurrentCam;
    public GameObject NextCam;

    public GameObject OverShoulderCamera;

    bool OverShoulderCam;
    void Start()
    {
        OverShoulderCam = false;
    }
    void Update()
    {
        if (Input.GetKey("c") && OverShoulderCam == false)
        {
            OverShoulderCam = true;
            Debug.Log("ShouldeCam = true");
            CurrentCam.SetActive(false);
            NextCam.SetActive(false);
            OverShoulderCamera.SetActive(true);
        }

        if (Input.GetKey("v") && OverShoulderCam == true)
        {
            OverShoulderCam = false;
            Debug.Log("ShouldeCam = false");
            CurrentCam.SetActive(false);
            NextCam.SetActive(false);
            OverShoulderCamera.SetActive(true);
        }
    }

    public void OnTriggerEnter(Collider other) 
    {
        if (OverShoulderCam == true) 
        {
            OverShoulderCamera.SetActive(true);
            CurrentCam.SetActive(false);
            NextCam.SetActive(false);
            Debug.Log("ShouldeCam executed 1");
        } 
        else if(OverShoulderCam == false)
        {
            OverShoulderCamera.SetActive(false);
            CurrentCam.SetActive(true);
            NextCam.SetActive(false);
            Debug.Log("ShouldeCam executed 2");
        }
    }
}
