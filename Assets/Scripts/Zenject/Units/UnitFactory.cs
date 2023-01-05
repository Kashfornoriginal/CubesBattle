using UnityEngine;
using Zenject;

public class UnitFactory : IUnitFactory
{
    private readonly DiContainer _diContainer;

    private const string UnitPath = "Unit";
    
    private Object _regularUitPrefab;

    public UnitFactory(DiContainer diContainer)
    {
        _diContainer = diContainer;
    }

    public void Load()
    {
        _regularUitPrefab = Resources.Load(UnitPath);
    }

    public void Create(Vector3 enemyPosition)
    {
        _diContainer.InstantiatePrefab(_regularUitPrefab, enemyPosition, Quaternion.identity, null);
    }
}