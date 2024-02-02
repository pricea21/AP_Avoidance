using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleAvoid : Seek
{
    public float avoidDistance = 3f;

    public float lookAhead = 5f;

    protected override Vector3 getTargetPosition()
    {
        RaycastHit hit;
        if (Physics.Raycast(character.transform.position, character.linearVelocity, out hit, lookAhead))
        {
            Debug.DrawRay(character.transform.position, character.linearVelocity.normalized * hit.distance, Color.red, 0.5f);
            Debug.Log("Hit " + hit.collider);
            return hit.point + (hit.normal * avoidDistance);
        }
        else
        {
            Debug.DrawRay(character.transform.position, character.linearVelocity.normalized * lookAhead, Color.green, 0.5f);
            Debug.Log("safe");
            return base.getTargetPosition();
        }
    }

}
