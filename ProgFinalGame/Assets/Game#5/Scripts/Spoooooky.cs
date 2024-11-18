using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spoooooky : MonoBehaviour
{
    public AudioSource Clicking;
    public GameObject Flashlight;
    

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(Flashes());
        }
    }

    IEnumerator Flashes()
    {
        Clicking.enabled = true;
        Flashlight.SetActive(false);
        yield return new WaitForSeconds(.2f);
        Flashlight.SetActive(true);
        yield return new WaitForSeconds(.2f);
        Flashlight.SetActive(false);
        yield return new WaitForSeconds(.2f);
        Flashlight.SetActive(true);
        yield return new WaitForSeconds(.2f);
        Flashlight.SetActive(false);
        yield return new WaitForSeconds(.2f);
        Flashlight.SetActive(true);
        yield return new WaitForSeconds(.2f);
        Flashlight.SetActive(false);
        yield return new WaitForSeconds(.2f);
        Flashlight.SetActive(true);
        yield return new WaitForSeconds(.2f);
        Flashlight.SetActive(false);
        yield return new WaitForSeconds(.2f);
        Flashlight.SetActive(true);
        yield return new WaitForSeconds(.2f);
        Flashlight.SetActive(false);
        yield return new WaitForSeconds(.2f);
        Flashlight.SetActive(true);
        yield return new WaitForSeconds(.2f);
        Flashlight.SetActive(false);
        yield return new WaitForSeconds(.2f);
        Flashlight.SetActive(true);
        Clicking.enabled = false;

    }
}
