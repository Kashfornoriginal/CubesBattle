using UnityEngine;

public interface IDestinationSetter
{
    //public Vector3 SetTargetDestination();

    public Vector3 SetRandomDestination(Vector3 startPosition, float minWalkableDistance, float maxWalkableDistance);
}