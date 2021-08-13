using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class spawn : MonoBehaviour
{
    public GameObject enemy;
    public float wave;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("sps");

    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator sps()
    {
        yield return new WaitForSeconds(1f);
        if (wave > 0)
        {
            Instantiate(enemy, transform.position, transform.rotation);
            wave -= 1;
        }
        StartCoroutine("sps");
    }
}
