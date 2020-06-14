using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nail : MonoBehaviour
{
    public Transform nailRenderer;
    public float downDepth = 0;

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
        if (other.tag == "Hammer")
        {
            nailRenderer.transform.position = new Vector3(0f, downDepth, transform.position.z);
            
            gameObject.GetComponent<Collider>().enabled = false;
            Debug.Log("POPAL");

            AudioManager.isNailSound = true;
        }
    }
}
