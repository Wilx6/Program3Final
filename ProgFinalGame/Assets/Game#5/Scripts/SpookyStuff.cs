using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpookyStuff : MonoBehaviour
{
    public AudioSource Lightning;
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
            StartCoroutine(Strikes());
        }
    }

    IEnumerator Strikes()
    {
        Lighting.color = Color.white;
        yield return new WaitForSeconds(.2f);
        Lighting.color = new Color(.19f, .19f, .19f);
        yield return new WaitForSeconds(.2f);
        Lighting.color = Color.white;
        Lightning.enabled = true;
        yield return new WaitForSeconds(.2f);
        Lighting.color = new Color(.19f, .19f, .19f);
        yield return new WaitForSeconds(.2f);
        Lighting.color = Color.white;
        yield return new WaitForSeconds(.2f);
        Lighting.color = new Color(.19f, .19f, .19f);
        yield return new WaitForSeconds(.2f);
        Lighting.color = Color.white;
        yield return new WaitForSeconds(.2f);
        Lighting.color = new Color(.19f, .19f, .19f);
        yield return new WaitForSeconds(1);
        Lightning.enabled = false;




    }
}
