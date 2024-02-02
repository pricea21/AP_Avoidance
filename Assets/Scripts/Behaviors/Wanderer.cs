using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Wanderer : Kinematic
{
    Wander myMoveType;
    Align myRotateType;

    void Start()
    {
        myMoveType = new Wander();
        myMoveType.character = this;

        myRotateType = new Face();
        myRotateType.character = this;
        myRotateType.target = myTarget;
    }

    protected override void Update()
    {
        steeringUpdate = new SteeringOutput();
        steeringUpdate.linear = myMoveType.getSteering().linear;
        steeringUpdate.angular = myRotateType.getSteering().angular;
        base.Update();
    }
}
