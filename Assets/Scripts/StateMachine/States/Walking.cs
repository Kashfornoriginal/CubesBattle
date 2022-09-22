using UnityEngine;
using Zenject;

public class Walking : MonoBehaviour, IState
{
    private IDestinationSetter _destinationSetter;
    
    [Inject]public void Construct(IDestinationSetter destinationSetter)
    {
        _destinationSetter = destinationSetter;
    }
    
    public void OnEnter()
    {
        
    }

    public void OnExit()
    {
        
    }
    
    public void Tick()
    {
        
    }
}
