using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Actuators;

public class Move_To_Target_Agent : Agent
{
    public override void OnActionReceived(ActionBuffers actions)
    {
        float moveX = actions.ContinuousActions[0];
        float moveY = actions.ContinuousActions[1];
        float movementSpeed = 5f;
        transform.localPosition += new Vector3(moveX, moveY) * Time.deltaTime *
        movementSpeed;
    }
}
