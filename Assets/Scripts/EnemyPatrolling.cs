using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyPatrolling : MonoBehaviour
{
    NavMeshAgent agent;
    public Transform[] waypoints;
    int waypointIndex;
    Vector3 target;
     
    public bool canseePlayer;
    public GameObject player;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        UpdateDestination();  
        
    }

    void Update()
    {
      if(canseePlayer==true)
        {
            target = player.transform.position;
            agent.SetDestination(target);
        }
        else if (Vector3.Distance(transform.position, target) < 1 && canseePlayer == false)
        {
            IterateWaypointindex();
            UpdateDestination();

        }
    }

    void UpdateDestination()
    {
        target = waypoints[waypointIndex].position;
        agent.SetDestination(target);
    }
    void IterateWaypointindex()
    {
        waypointIndex++;
        if (waypointIndex == waypoints.Length)
        {
            waypointIndex = 0;
        }
    }

  

    //minuto 4:03 https://youtu.be/c8Nq19gkNfs?si=u00H5e9s9iG-dIp8
}
