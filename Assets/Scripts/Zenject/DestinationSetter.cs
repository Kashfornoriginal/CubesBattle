using UnityEngine;

public class DestinationSetter : MonoBehaviour, IDestinationSetter
{
    public Vector3 SetRandomDestination(Vector3 startPosition, float minWalkableDistance, float maxWalkableDistance)
    {
        return GenerateRoamingPosition(startPosition, minWalkableDistance, maxWalkableDistance);
    }

    private Vector3 GenerateRoamingPosition(Vector3 startPosition, float minWalkableDistance, float maxWalkableDistance)
    {
        Vector3 roamingPosition = startPosition + GenerateRandomDirection() * Random.Range(minWalkableDistance, maxWalkableDistance);
        return roamingPosition;
    }
    
    private Vector3 GenerateRandomDirection()
    {
        Vector3 direction = new Vector3(Random.Range(-1f, 1f),0 ,Random.Range(-1f, 1f)).normalized;
        return direction;
    }
}