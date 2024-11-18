using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringTrapScare : MonoBehaviour
{
    
    public GameObject SpringTrap;
    public AudioSource Laugh;

    private bool triggered = false;
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
        if (other.tag == "Player")
        {
            
            StartCoroutine(Poof());
        }

    }
    
    IEnumerator Poof()
    {
        yield return new WaitForSeconds(1.85f);
        Laugh.enabled = true;
        yield return new WaitForSeconds(.15f);
        SpringTrap.SetActive(false);
    }
}
