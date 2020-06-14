using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigNail : MonoBehaviour
{
    //public Transform nailRenderer;
    public float downDepth = 0;
    public int hitCount = 3;

    private int hits = 0;
    //public int hitsCount = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hits == hitCount)
            GameController.isWin = true;
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Hammer")
        {
            gameObject.transform.position = new Vector3(0f, transform.position.y - downDepth, transform.position.z);
            hits++;
        }
    }
}
