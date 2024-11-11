using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTriggers : MonoBehaviour
{

    private Animator myDoor;
    public AudioSource DoorOpening;
    public AudioSource DoorClosing;
    public AudioSource DoorOpenFast;

    FirstPerson firstPerson;
    [SerializeField] GameObject player;

    private void Awake()
    {
        firstPerson = player.GetComponent<FirstPerson>();
    }

    void Start()
    {
        myDoor = GetComponent<Animator>();
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player") && firstPerson.isRunning == true)
        {
            myDoor.SetTrigger("FastOpen");
            DoorOpenFast.enabled = true;
            DoorOpening.enabled = false;
            DoorClosing.enabled = false;

        }
        
        else if (other.CompareTag("Player"))
        {
            myDoor.SetTrigger("Open");
            DoorOpening.enabled = true;
            DoorClosing.enabled = false;
            DoorOpenFast.enabled = false;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            myDoor.SetTrigger("Closed");
            DoorClosing.enabled = true;
            DoorOpening.enabled = false;
            DoorOpenFast.enabled = false;
        }
    }



}
