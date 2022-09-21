using UnityEngine;

public class EnemySpawnPoint : MonoBehaviour
{
    [SerializeField] private EnemyType _enemyType;

    public EnemyType EnemyType => _enemyType;

    private void OnDrawGizmos()
    {
        Gizmos.DrawSphere(transform.position, 1);
    }
}

public enum EnemyType
{
    Regular
}
