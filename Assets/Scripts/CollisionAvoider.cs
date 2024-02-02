using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionAvoider : Kinematic
{
    CollisonAvoidance myMoveType;

    public Kinematic[] myTargets = new Kinematic[4];

    void Start()
    {
        myMoveType = new CollisonAvoidance();
        myMoveType.character = this;
        myMoveType.targets = myTargets;
    }

    protected override void Update()
    {
        steeringUpdate = myMoveType.getSteering();
        base.Update();
    }
}
