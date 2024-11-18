using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Troll : MonoBehaviour
{

    public AudioSource Trolll;
    public GameObject Sun;
    private Light Lighting;

    // Start is called before the first frame update
    void Start()
    {
        Lighting = Sun.GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Trolll.enabled = true;
            Lighting.color = Color.white;
        }
    }
}
