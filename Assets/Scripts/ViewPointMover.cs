using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewPointMover : MonoBehaviour
{
    public float moveSpeed = 2;

    private bool isRunning = false;
    private bool isFinish = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isRunning == true && isFinish == false && GameController.isOver == false)
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime, Space.World);

        if (Input.GetMouseButtonDown(0))
            isRunning = true;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Finish")
            isFinish = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Nail")
            GameController.misses++;
    }
}
