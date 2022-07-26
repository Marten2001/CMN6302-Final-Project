using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class StalkingAI : MonoBehaviour
{
    public GameObject stalkerDest;
    private NavMeshAgent stalkerAgent;
    public GameObject stalkerEnemy;
    public static bool isStalking;

    // Start is called before the first frame update
    void Start()
    {
        stalkerAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isStalking == false)
        {
            stalkerEnemy.GetComponent<Animator>().Play("Idle_001");
        }
        else
        {
            stalkerEnemy.GetComponent<Animator>().Play("Walking_001");
            stalkerAgent.SetDestination(stalkerDest.transform.position);
        }
    }
}
