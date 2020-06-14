using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer : MonoBehaviour
{
    private Animator anim;
    public GameObject crack;
    private int clickCount = 0;

    private bool isNail = false;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickCount++;
            if (clickCount > 1)
                anim.SetTrigger("Attack");
        }

        Debug.Log("Is nail" + isNail);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        if (other.tag == "Nail" || other.tag == "Finish")
            isNail = true;

        if (other.tag == "Plank" && isNail == false)
        {
            Instantiate(crack, new Vector3(0f, 0.14f, transform.position.z), Quaternion.Euler(90, 0, 0));
            GameController.misses++;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        isNail = false;
    }
}
