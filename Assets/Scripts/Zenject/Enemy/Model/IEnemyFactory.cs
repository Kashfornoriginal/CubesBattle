using UnityEngine;

public interface IEnemyFactory
{
    void Load();
    void Create(EnemyType type, Vector3 enemyPosition);
}