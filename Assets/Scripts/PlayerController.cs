using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{

    public float moveSpeed;
    public float turnSpeed;
    public Rigidbody rb; 
    public GameObject CamOne;
    public GameObject CamTwo;
    public GameObject CamThree;
    public GameObject CamFour;
    public GameObject CamFive;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Time.timeScale = 1;
    }

    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * (moveSpeed * Time.deltaTime), 0, Input.GetAxis("Vertical") * (moveSpeed * Time.deltaTime));
        transform.Rotate(Vector3.up * Input.GetAxis("Mouse X") * (turnSpeed * Time.deltaTime));
    }

    public void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.name == "ZoneOne") {
            CamOne.SetActive(true);
        }
        
        if (other.gameObject.name == "ZoneTwo") {
            CamTwo.SetActive(true);
        }

        if (other.gameObject.name == "ZoneThree") {
             CamThree.SetActive(true);
        }
        
        if (other.gameObject.name == "ZoneFour") {
             CamFour.SetActive(true);
        }

        if (other.gameObject.name == "ZoneFive") {
             CamFive.SetActive(true);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "ZoneOne") {
            CamOne.SetActive(false);
        }
        
        if (other.gameObject.name == "ZoneTwo") {
            CamTwo.SetActive(false);
        }

        if (other.gameObject.name == "ZoneThree") {
            CamThree.SetActive(false);
        }
        
        if (other.gameObject.name == "ZoneFour") {
            CamFour.SetActive(false);
        }

        if (other.gameObject.name == "ZoneFive") {
            CamFive.SetActive(false);
        }
    }

}


