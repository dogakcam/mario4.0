using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public float LookRadius = 10.0f;
    Transform target;
    NavMeshAgent agent;
    public EnemyPatrol patrolController;

    // Start is called before the first frame update
    void Start()
    {
        
        agent = GetComponent<NavMeshAgent>();
        target = PlayerManager.instance.Player.transform;
        patrolController.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);
        if (distance <= LookRadius)
        {
             patrolController.enabled = false;
             agent.SetDestination(target.position);
        }
        else
        {
            patrolController.enabled = true;
        }
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, LookRadius);
    }
}
