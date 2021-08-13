using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ac_S : MonoBehaviour
{
    public GameObject Skill;
    public float S_Time;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("SkC");
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator SkC()
    {
        yield return new WaitForSeconds(S_Time);
        Instantiate(Skill, transform.position + new Vector3(0, 0, 0), transform.rotation);
        StartCoroutine("SkC");
    }
}
