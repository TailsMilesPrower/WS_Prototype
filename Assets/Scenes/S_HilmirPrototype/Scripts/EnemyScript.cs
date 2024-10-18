using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyScript : MonoBehaviour
{
    public NavMeshAgent agent;
    public List<Transform> waypointPos = new List<Transform>();
    public int index = 0;
    public bool forward = true;
    public float time;
    // Start is called before the first frame update
    // Tor Arne helped me with this code    
    void Start()
    {
        SetNextWaypoint();
    }

    // Update is called once per frame
    void Update()
    {
        if (DestinationReached())
        {
            SetNextWaypoint();
        }
    }
    private bool DestinationReached()
    {
        return Vector3.Distance(transform.position, waypointPos[index].position)<1.7f;
    }
    private void SetNextWaypoint()
    {
        if (forward)
        {
            bool underwaypointCheck = index + 1 < waypointPos.Count;
            index = (underwaypointCheck) ? index + 1 : index - 1;
            
            if (!underwaypointCheck)
            {
                forward = false;
            }
            // Move Character
            agent.SetDestination(waypointPos[index].position);
        }
        else
        {
            bool underwaypointCheck = index - 1 > 0;
            index = (underwaypointCheck) ? index - 1 : 1;

            if (!underwaypointCheck)
            {
                forward = true;
            }
            // Move Character
            agent.SetDestination(waypointPos[index].position);
        }
    }
}
