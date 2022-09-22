using UnityEngine;
using Zenject;

public class DestinationSetterInstaller : MonoInstaller
{
    [SerializeField] private DestinationSetter _destinationSetter; 
    public override void InstallBindings()
    {
        Container.Bind<IDestinationSetter>().To<DestinationSetter>().FromInstance(_destinationSetter).AsSingle();
    }
}
