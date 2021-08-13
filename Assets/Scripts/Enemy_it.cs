using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Navigation 관련 기능을 사용할 때 필요.
using UnityEngine.AI;
[RequireComponent(typeof(NavMeshAgent))]

public class Enemy_it : MonoBehaviour
{
    // 목표 지점
    public Transform target;
    NavMeshAgent agent;

    public Transform enemy;
    public Animation Enem_R;
    public float Speed;
    
    void Start()
    {
        // 해당 개체의 NavMeshAgent 를 참조합니다.
        agent = GetComponent<NavMeshAgent>();

        Enem_R.Play("Run");
    }

    void Update()
    {
        // 매프레임마다 목표지점으로 이동합니다.
        agent.SetDestination(target.position);
        enemy.transform.Translate(Vector3.forward * Time.deltaTime * Speed);
        Speed += 0.03f;

        Enem_R.Play("Run");

    }
}