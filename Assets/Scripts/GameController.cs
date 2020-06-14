using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Renderer star1;
    public Renderer star2;
    public Renderer star3;
    public Material lostStarMat;

    public static int misses = 0;

    public int missesCountToFail = 3;

    // Start is called before the first frame update
    void Start()
    {
        misses = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Misses: " + misses);
        if (misses == missesCountToFail)
        {
            star1.material = lostStarMat;
        }
    }
}
