using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewPointMover : MonoBehaviour
{
    public float moveSpeed = 2;

    private bool isRunning = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isRunning == true)
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime, Space.World);

        if (Input.GetMouseButtonDown(0))
            isRunning = true;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Finish")
            isRunning = false;
    }
}
