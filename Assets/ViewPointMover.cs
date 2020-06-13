using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewPointMover : MonoBehaviour
{
    public float moveSpeed = 2;

    private bool isFinish = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isFinish == false)
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime, Space.World);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Finish")
            isFinish = true;
    }
}
