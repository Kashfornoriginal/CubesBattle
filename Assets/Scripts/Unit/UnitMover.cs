using UnityEngine;
using Zenject;

public class UnitMover : MonoBehaviour, IUnitMover
{
    [SerializeField] private float _moveSpeed;
    
    private IPlayerUnit _playerUnit;
    
    [Inject]
    public void Construct(IPlayerUnit playerUnit)
    {
        _playerUnit = playerUnit;
    }

    private void Update()
    {
        MoveTo(_playerUnit.Position, _moveSpeed * Time.deltaTime);
    }

    public void MoveTo(Vector3 moveTarget, float moveSpeed)
    {
        if (Vector3.Distance(gameObject.transform.position, moveTarget) < 1)
        {
            return;
        }
        gameObject.transform.position = Vector3.MoveTowards(transform.position, moveTarget, moveSpeed);
    }
}
