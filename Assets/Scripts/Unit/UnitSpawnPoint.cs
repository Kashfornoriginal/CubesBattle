using UnityEngine;

public class UnitSpawnPoint : MonoBehaviour
{
    [SerializeField] private UnitType unitType;

    public UnitType UnitType => unitType;

    private void OnDrawGizmos()
    {
        Gizmos.DrawSphere(transform.position, 1);
    }
}

public enum UnitType
{
    Regular
}
