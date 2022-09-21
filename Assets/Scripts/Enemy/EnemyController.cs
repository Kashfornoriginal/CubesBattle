using System;
using UnityEngine;
using Zenject;

public class EnemyController : MonoBehaviour
{
    private PlayerUnit _playerUnit;

    [Inject] private void Construct(PlayerUnit playerUnit)
    {
        _playerUnit = playerUnit;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log(_playerUnit.transform.position);
        }
    }
}
