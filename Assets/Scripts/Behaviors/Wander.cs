using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wander : SteeringBehavior
{
    public Kinematic character; 
    //float wanderOffset;
    //float wanderRadius;
   // float wanderMaxRate;
    float wanderOrr = 10f;
    float maxAcc = 1f;

    public override SteeringOutput getSteering()
    {
        SteeringOutput result = new SteeringOutput();

        result.linear = maxAcc * character.transform.forward;
        result.angular = RandomBinomial() * wanderOrr;

        return result;
    }

    private float RandomBinomial()
    {
        return Random.value - Random.value;
    }
}
