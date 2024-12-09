using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreepyHallway : MonoBehaviour
{
    public AudioSource CrepppyMusic;
    public AudioSource BGM;
    public GameObject Door;
    public GameObject Wall;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"));
        {
            BGM.enabled = false;
            CrepppyMusic.enabled = true;
            Door.SetActive(false);
            Wall.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"));
        {
            CrepppyMusic.enabled = false;
        }
    }
}
