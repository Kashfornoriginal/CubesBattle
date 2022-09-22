using UnityEngine;

[CreateAssetMenu(fileName = "UnitColorDecorator", menuName = "Unit/UnitConfig")]
public class UnitConfig : ScriptableObject
{
    [SerializeField] private Mesh _shape;
    [SerializeField] private Color _color;
    [SerializeField] private float _size;
    [SerializeField] private float _maxHealth;
    [SerializeField] private float _maxSpeed;
    [SerializeField] private float _attackDamage;
    [SerializeField] private float _attackSpeed;

    public Mesh Shape => _shape;
    public Color Color => _color;
    public float Size => _size;
    public float MaxHealth => _maxHealth;
    public float MaxSpeed => _maxSpeed;
    public float AttackDamage => _attackDamage;
    public float AttackSpeed => _attackSpeed;
}
