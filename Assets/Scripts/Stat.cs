using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stat : MonoBehaviour
{
    public Transform Camera;
    public float Time;
    public Joystick js;

    public Animation run;

    
    // Start is called before the first frame update
    void Start()
    {
        run.Stop("Run");
    }

    // Update is called once per frame
    void Update()
    {
        if (js.MoveFlag)
        {
            run.Play("Run");
        }
        else
        {
            run.Stop("Run");
            run.Play("idle");
        }

    float moveZ = 0f;
    float moveX = 0f;

    // if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)){
    //     moveZ += 1f;
    //     run.Play("Run");
    // }

    // if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)){
    //     moveZ -= 1f;
    //     run.Play("Run");
    // }

    // if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)){
    //     moveX -= 1f;
    //     run.Play("Run");
    // }

    // if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)){
    //     moveX += 1f;
    //     run.Play("Run");
    // }

        transform.Translate(new Vector3(moveX, 0f, moveZ) * 0.1f);
        
        Camera.transform.position = transform.position + new Vector3(0, 14, -7);
    }
}


