using UnityEngine;
using Zenject;

public class EnemyInstaller : MonoInstaller, IInitializable
{
    [SerializeField] private EnemySpawnPoint _enemySpawnPoint;
    [SerializeField] private int _enemyCount;

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

        for (int i = 0; i < _enemyCount; i++)
        {
            enemyFactory.Create(_enemySpawnPoint.EnemyType, _enemySpawnPoint.transform.position);
        }
    }
}