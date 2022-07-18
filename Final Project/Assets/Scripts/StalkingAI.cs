using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class StalkingAI : MonoBehaviour
{
    public GameObject stalkerDest;
    private NavMeshAgent stalkerAgent;

    // Start is called before the first frame update
    void Start()
    {
        stalkerAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        stalkerAgent.SetDestination(stalkerDest.transform.position);
    }
}
