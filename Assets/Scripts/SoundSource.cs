//사운드소스 코드

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSource : MonoBehaviour
{
    public Joystick js;

    public AudioClip ac;
    private AudioSource audiosource;




    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
        audiosource.playOnAwake = false;
        audiosource.loop = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (js.MoveFlag)
        {

        }
        else
        {
            audiosource.Play();
            audiosource.loop = true;

        }


    }


}
