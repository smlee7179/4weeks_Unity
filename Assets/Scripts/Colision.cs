//충돌 소스코드

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colision : MonoBehaviour
{
    private int colCount;  //충돌 횟수 카운트 함수

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "monster")
        {
            colCount = colCount + 1;
            Debug.Log("COLISION");
            Debug.Log(colCount);

        }
    }



    // Start is called before the first frame update
    void Start()
    {
        colCount = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
