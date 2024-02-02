using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPather : Kinematic
{
    FollowPath myMoveType;
    LookWhereGoing myRotateType;

    public GameObject[] targets;

    void Start()
    {
        myMoveType = new FollowPath();
        myMoveType.character = this;

        myMoveType.targets = targets;

        myRotateType = new LookWhereGoing();
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
