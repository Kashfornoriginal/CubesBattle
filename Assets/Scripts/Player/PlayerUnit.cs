using System;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class PlayerUnit : MonoBehaviour, IPlayerUnit, IDamagable
{
    [SerializeField] private int _health;

    public int Health => _health;
    public Vector3 Position => transform.position;
    public void ApplyDamage(int damage)
    {
        if (damage < 0)
        {
            throw new ArgumentOutOfRangeException($"Damage is negative {damage}");
        }
        if (_health - damage > 0)
        {
            _health -= damage;
            return;
        }

        Die();
    }

    private void Die()
    {
        Debug.Log("Died");
    }
}
