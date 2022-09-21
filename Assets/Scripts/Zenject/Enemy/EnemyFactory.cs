using UnityEngine;
using Zenject;

public class EnemyFactory : IEnemyFactory
{
    private readonly DiContainer _diContainer;

    private const string EnemyPath = "Enemy";
    
    private Object _regularEnemyPrefab;

    public EnemyFactory(DiContainer diContainer)
    {
        _diContainer = diContainer;
    }

    public void Load()
    {
        _regularEnemyPrefab = Resources.Load(EnemyPath);
    }

    public void Create(EnemyType type, Vector3 enemyPosition)
    {
        switch (type)
        {
            case EnemyType.Regular:
                _diContainer.InstantiatePrefab(_regularEnemyPrefab, enemyPosition, Quaternion.identity, null);
                break;
        }
    }
}