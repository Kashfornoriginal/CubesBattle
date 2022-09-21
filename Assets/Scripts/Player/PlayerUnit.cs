using UnityEngine;

public class PlayerUnit : MonoBehaviour, IPlayerUnit
{
    [SerializeField] private int _health;

    public int Health => _health;
    public Vector3 Position => transform.position;
}
