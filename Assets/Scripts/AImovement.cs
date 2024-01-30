using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AImovement : MonoBehaviour
{
    private GameObject endPoint;
    private NavMeshAgent agent;
    [SerializeField]
    private Animator animator;
    private const string IsWalking = "IsMoving";
    // Start is called before the first frame update
    void Start()
    {

        endPoint = GameObject.FindGameObjectWithTag("End");

        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(endPoint.transform.position);

    }
    private void Update()
    {
        animator.SetBool(IsWalking, agent.velocity.magnitude > 0.01f);
    }
}
