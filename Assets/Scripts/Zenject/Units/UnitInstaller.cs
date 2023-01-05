using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class UnitInstaller : MonoInstaller, IInitializable
{
    [SerializeField] private List<UnitSpawnPoint> _spawnPoints;

    public override void InstallBindings()
    {
        BindInstallerInterfaces();
        BindEnemyFactory();
    }

    private void BindEnemyFactory()
    {
        Container.Bind<IUnitFactory>().To<UnitFactory>().AsSingle();
    }

    private void BindInstallerInterfaces()
    {
        Container.BindInterfacesTo<UnitInstaller>().FromInstance(this).AsSingle();
    }

    public void Initialize()
    {
        var unitFactory = Container.Resolve<IUnitFactory>();
        
        unitFactory.Load();

        foreach (var spawnPoint in _spawnPoints)
        {
            unitFactory.Create(spawnPoint.transform.position);
        }
    }
}