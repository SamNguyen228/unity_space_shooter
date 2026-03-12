using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public FlyPath flyPath;
    public float speed = 3f;

    private int waypointIndex = 0;

    void Update()
    {
        if (flyPath == null) return;

        Transform target = flyPath.waypoints[waypointIndex].transform;

        transform.position = Vector3.MoveTowards(
            transform.position,
            target.position,
            speed * Time.deltaTime
        );

        if (Vector3.Distance(transform.position, target.position) < 0.1f)
        {
            waypointIndex++;

            if (waypointIndex >= flyPath.waypoints.Length)
            {
                waypointIndex = 0;
            }
        }
    }
}