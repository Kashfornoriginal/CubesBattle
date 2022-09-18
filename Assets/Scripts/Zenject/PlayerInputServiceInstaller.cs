using UnityEngine;
using Zenject;

public class PlayerInputServiceInstaller : MonoInstaller
{
    [SerializeField] private PlayerInputService _playerInputServicePrefab;
    
    public override void InstallBindings()
    {
        Container.Bind<IPlayerInputService>().To<PlayerInputService>()
            .FromComponentInNewPrefab(_playerInputServicePrefab).AsSingle();
    }
}
