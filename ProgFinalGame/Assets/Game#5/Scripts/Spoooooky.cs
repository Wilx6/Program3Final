using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spoooooky : MonoBehaviour
{
    public AudioSource Clicking;
    public GameObject Flashlight;

    Coroutine c;
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
            c = StartCoroutine(Flashes());
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            StopCoroutine(c);
            Clicking.enabled = false;
            Flashlight.SetActive(true);
        }
    }

    IEnumerator Flashes()
    {
        while (true)
        {
            Clicking.enabled = true;
            yield return new WaitForSeconds(.2f);
            Clicking.enabled = false;
            Flashlight.SetActive(false);
            yield return new WaitForSeconds(.5f);
            Clicking.enabled = true;
            yield return new WaitForSeconds(.2f);
            Clicking.enabled = false;
            Flashlight.SetActive(true);
            yield return new WaitForSeconds(.4f);
            Clicking.enabled = true;
            yield return new WaitForSeconds(.2f);
            Clicking.enabled = false;
            Flashlight.SetActive(false);
            yield return new WaitForSeconds(.2f);
            Clicking.enabled = true;
            yield return new WaitForSeconds(.2f);
            Clicking.enabled = false;
            Flashlight.SetActive(true);
            yield return new WaitForSeconds(.2f);
            Clicking.enabled = true;
            yield return new WaitForSeconds(.2f);
            Clicking.enabled = false;
            Flashlight.SetActive(false);
            yield return new WaitForSeconds(.2f);
            Clicking.enabled = true;
            yield return new WaitForSeconds(.2f);
            Clicking.enabled = false;
            Flashlight.SetActive(true);
            yield return new WaitForSeconds(.2f);
            Clicking.enabled = true;
            yield return new WaitForSeconds(.2f);
            Clicking.enabled = false;
            Flashlight.SetActive(false);
            yield return new WaitForSeconds(.5f);
            Clicking.enabled = true;
            yield return new WaitForSeconds(.2f);
            Clicking.enabled = false;
            Flashlight.SetActive(true);
            yield return new WaitForSeconds(.2f);
            Clicking.enabled = true;
            yield return new WaitForSeconds(.2f);
            Clicking.enabled = false;
            Flashlight.SetActive(false);
            yield return new WaitForSeconds(.4f);
            Clicking.enabled = true;
            yield return new WaitForSeconds(.2f);
            Clicking.enabled = false;
            Flashlight.SetActive(true);
            yield return new WaitForSeconds(.2f);
            Clicking.enabled = true;
            yield return new WaitForSeconds(.2f);
            Clicking.enabled = false;
            Flashlight.SetActive(false);
            yield return new WaitForSeconds(.2f);
            Clicking.enabled = true;
            yield return new WaitForSeconds(.2f);
            Clicking.enabled = false;
            Flashlight.SetActive(true);
            yield return new WaitForSeconds(.3f);
            Clicking.enabled = true;
            yield return new WaitForSeconds(.2f);
            Clicking.enabled = false;
            Flashlight.SetActive(false);
            yield return new WaitForSeconds(.2f);
            Clicking.enabled = true;
            yield return new WaitForSeconds(.2f);
            Clicking.enabled = false;
            Flashlight.SetActive(true);
            Clicking.enabled = false;
        }

    }
}
