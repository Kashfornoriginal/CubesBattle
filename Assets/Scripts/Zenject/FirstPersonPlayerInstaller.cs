 using UnityEngine;
using Zenject;

public class FirstPersonPlayerInstaller : MonoInstaller
{
    [SerializeField] private PlayerUnit _playerUnit;

    public override void InstallBindings()
    {
        var playerInstance = Container.InstantiatePrefabForComponent<PlayerUnit>(_playerUnit, Vector3.zero, Quaternion.identity, null);

        Container.Bind<PlayerUnit>().FromInstance(playerInstance).AsSingle();
        Container.QueueForInject(playerInstance);
    }
}