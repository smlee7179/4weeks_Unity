//�浹 �ҽ��ڵ�

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colision : MonoBehaviour
{
    private int colCount;  //�浹 Ƚ�� ī��Ʈ �Լ�

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
