using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{  NavMeshAgent agent;
    public Transform[] wayPoints;
    int waypointIndex;
    Vector3 target;
    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        Updatedestination();
    }
    private void Update()
    {
        if (Vector3.Distance(transform.position, target)<1)
        {
            Iteratewaypointindex();
            Updatedestination();

        }
    }
    void Updatedestination() {

        target = wayPoints[waypointIndex].position;
        agent.SetDestination(target);
    }
    void Iteratewaypointindex() { 
    waypointIndex++;
        if (waypointIndex==wayPoints.Length) { 
        waypointIndex = 0;
        }
    }
}
