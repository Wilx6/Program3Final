using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringTrapScare : MonoBehaviour
{
    
    public GameObject SpringTrap;
    public AudioSource Laugh;
    public float speed;
    public bool touch;
    
    // Start is called before the first frame update
    void Start()
    {
        touch = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (touch == true)
        {
            
            transform.position += transform.forward * speed * Time.deltaTime;
        }
        
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

        
        touch = true;
        Laugh.enabled = true;
        yield return new WaitForSeconds(1f);
        SpringTrap.SetActive(false);
    }
}
