using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill : MonoBehaviour
{
    public Rigidbody skill_R;
    public float speed_SR;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("SC");
    }

    // Update is called once per frame
    void Update()
    {
        //미사일 발사 함수
        Vector3 TmpPos = transform.position;
        TmpPos += transform.forward * 0.5f; //전방 벡터 구하는 법 알아보기!!!!!
        transform.position = TmpPos;
    }

    void OnCollisionEnter(Collision a) //a가 충돌한 물체
    {
        if (a.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }

    IEnumerator SC()
    {
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }
}
