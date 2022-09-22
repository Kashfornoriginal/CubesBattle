using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class EnemyInstaller : MonoInstaller, IInitializable
{
    [SerializeField] private EnemySpawnPoint _enemySpawnPoint;
    [SerializeField] private List<EnemySpawnPoint> _spawnPoints;

    public override void InstallBindings()
    {
        BindInstallerInterfaces();
        BindEnemyFactory();
    }

    private void BindEnemyFactory()
    {
        Container.Bind<IEnemyFactory>().To<EnemyFactory>().AsSingle();
    }

    private void BindInstallerInterfaces()
    {
        Container.BindInterfacesTo<EnemyInstaller>().FromInstance(this).AsSingle();
    }

    public void Initialize()
    {
        var enemyFactory = Container.Resolve<IEnemyFactory>();
        
        enemyFactory.Load();

        foreach (var spawnPoint in _spawnPoints)
        {
            enemyFactory.Create(_enemySpawnPoint.EnemyType, spawnPoint.transform.position);
        }
    }
}