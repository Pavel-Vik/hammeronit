using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip woodhit;
    public AudioClip music;
    public AudioClip hammerSound;
    public AudioClip bigNailHit;
    public AudioClip winSound;

    public static bool isNailSound = false;
    public static bool isWinSound = false;

    private AudioSource audSrc;

    private void Start()
    {
        audSrc = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        if (isNailSound == true)
        {

            audSrc.PlayOneShot(hammerSound);
            isNailSound = false;
        }

        //if (isBigNailSound == true)
        //{

        //    audSrc.PlayOneShot(bigNailHit);
        //    isNailSound = false;
        //}
    }

   public void WoodHit()
    {
        GetComponent<AudioSource>().PlayOneShot(woodhit);
    }

    public void BigNailHit()
    {
        GetComponent<AudioSource>().PlayOneShot(bigNailHit);
    }
    
    public void WinSound()
    {
        GetComponent<AudioSource>().PlayOneShot(winSound);
    }
}
