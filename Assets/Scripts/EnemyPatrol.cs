using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyPatrol : MonoBehaviour
{
    public float speed;
    public Transform[] MoveSpots;
    public float StartWaitTime;
    private int RandomSpot;
    private float WaitTime;
    NavMeshAgent agent;
    Transform target;

    // Start is called before the first frame update
    void OnEnable()
    {
        agent = GetComponent<NavMeshAgent>();
        WaitTime = StartWaitTime;
        //RandomSpot = Random.Range(0, MoveSpots.Length);
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, agent.destination) < 0.2f)
        {
            if(WaitTime <= 0)
            {
                Debug.Log("Enemy Moved");
                RandomSpot = Random.Range(0, MoveSpots.Length);
                agent.SetDestination(MoveSpots[RandomSpot].position);
                WaitTime = StartWaitTime;
            }
            else
            {
                WaitTime -= Time.deltaTime;
            }
        }
    }
}
