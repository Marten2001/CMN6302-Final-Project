using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIWander : MonoBehaviour
{
    enum AIStates
    {
        Idle,
        Wandering
    }

    public GameObject stalkerEnemy;
    public static bool isWalking;

    [SerializeField]
    private NavMeshAgent agent = null;
    [SerializeField]
    private LayerMask floorMask = 0;

    private AIStates curStates = AIStates.Idle;
    private float waitTimer = 0.0f;

    // Update is called once per frame
    void Update()
    {
       
        switch (curStates)
        {
            case AIStates.Idle:
                OnIdle();
          
                break;
            case AIStates.Wandering:
                OnWander();
                
                break;
            default:
                Debug.LogError("You Dare Enter My Home And Steal From Me?!");
                break;
        }
    }

    private void OnIdle()
    {
        if(waitTimer > 0)
        {
            waitTimer -= Time.deltaTime;
            return;
        }

        agent.SetDestination(RandomNavSphere(transform.position, 50.0f, floorMask));
        curStates = AIStates.Wandering;
        

    }

    private void OnWander()
    {
        if(agent.pathStatus != NavMeshPathStatus.PathComplete)
        {
            return;
        }

        waitTimer = Random.Range(1.0f, 4.0f);
        curStates = AIStates.Idle;
        
      
    }

    Vector3 RandomNavSphere(Vector3 origin, float distance, LayerMask layerMask)
    {
        Vector3 randomDirection = UnityEngine.Random.insideUnitSphere * distance;

        randomDirection += origin;

        NavMeshHit navHit;

        NavMesh.SamplePosition(randomDirection, out navHit, distance, layerMask);

        return navHit.position;
    }
 
}
