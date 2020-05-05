using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAI : MonoBehaviour
{
    public List<Transform> waypoints = new List<Transform>();
    private Transform targetWaypoints;
    private int targetWaypointIndex;
    private float minDistance = 0.1f;
    private int lastWaypointIndex;

    public float movementSpeed = 0.5f;

    public GameObject objToTP;
    public Transform tpLoc1;
    public Transform tpLoc2;

    private int randTP = 1;
    // Start is called before the first frame update
    void Start()
    {
        lastWaypointIndex = waypoints.Count - 1;
        targetWaypoints = waypoints[targetWaypointIndex];

    }

    // Update is called once per frame
    void Update()
    {
        float movementStep = movementSpeed * Time.deltaTime;

        float distance = Vector3.Distance(transform.position, targetWaypoints.position);
        CheckDistanceToWaypoint(distance);

        transform.position = Vector3.MoveTowards(transform.position, targetWaypoints.position, movementStep);

    }
    
    void CheckDistanceToWaypoint(float currentDistance)
    {
        if(currentDistance <= minDistance)
        {
            if(randTP == 0)
            {
                objToTP.transform.position = tpLoc1.transform.position;
                randTP = 1;
            }
            else
            {
                objToTP.transform.position = tpLoc2.transform.position;
                randTP = 0;
            }
            targetWaypointIndex++;
            UpdateTargetWaypoint();
        }
    }

    void UpdateTargetWaypoint()
    {
        if(targetWaypointIndex > lastWaypointIndex)
        {
            targetWaypointIndex = 0;
        }
        targetWaypoints = waypoints[targetWaypointIndex];
    }
}
