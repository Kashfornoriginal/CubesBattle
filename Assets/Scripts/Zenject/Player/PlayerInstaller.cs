using UnityEngine;
using Zenject;

 public class PlayerInstaller : MonoInstaller
 {
     [SerializeField] private PlayerUnit _playerUnit;

     public override void InstallBindings()
     {
         PlayerBind();
     }

     private void PlayerBind()
     {
         var playerInstance = Container.InstantiatePrefabForComponent<PlayerUnit>(_playerUnit, Vector3.zero, Quaternion.identity, null);
         Container.Bind<IPlayerUnit>().To<PlayerUnit>().FromInstance(playerInstance).AsSingle();
     }
 }