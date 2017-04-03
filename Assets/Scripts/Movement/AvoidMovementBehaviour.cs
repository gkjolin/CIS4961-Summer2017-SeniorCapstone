﻿using UnityEngine;

/// <summary>
/// When an agent has this movement behaviour it will actively desire to move
/// directly away from the location of the target.
/// </summary>
public class AvoidMovementBehaviour : DirectMovementBehaviour
{
    /// <summary>
    /// Constructor for AvoidMovementBehaviour instances.
    /// </summary>
    /// <param name="movementBehaviour">The movement behaviour to decorate.</param>
    /// <param name="agent">The GameObject that desires this movement behaviour.</param>
    /// <param name="target">The target of this movement behaviour.</param>
    public AvoidMovementBehaviour(AbstractMovementBehaviour movementBehaviour, GameObject agent, GameObject target)
         : base(movementBehaviour, agent, target) { }

    /// <summary>
    /// The steering vector desired by this movement behaviour.
    /// </summary>
    /// <returns>The optimal sterring vector to accomplish this movement behaviour.</returns>
    public override Vector2 Steering()
    {
        return movementBehaviour.Steering();
    }
}
