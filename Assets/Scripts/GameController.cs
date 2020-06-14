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
    public static bool isOver = false;

    public int missesForStar1 = 1;
    public int missesForStar2 = 1;
    public int missesForStar3 = 1;

    // Start is called before the first frame update
    void Start()
    {
        misses = 0;
        isOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Misses: " + misses);
        if (misses == missesForStar1)
        {
            star1.material = lostStarMat;
        }

        if (misses == missesForStar2)
        {
            star2.material = lostStarMat;
        }

        if (misses == missesForStar3)
        {
            star3.material = lostStarMat;
            isOver = true;
        }
    }


}
