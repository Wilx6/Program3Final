using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SrpingTrapWindow : MonoBehaviour
{

    public GameObject SpringTrap;
    public float speed;
    
    private bool triggered = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (triggered == true)
        {
            SpringTrap.transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            SpringTrap.SetActive(true);
            triggered = true;
            StartCoroutine(ByeBye());
        }
    }

    IEnumerator ByeBye()
    {
        yield return new WaitForSeconds(3.6f);
        SpringTrap.SetActive(false);
    }
}
