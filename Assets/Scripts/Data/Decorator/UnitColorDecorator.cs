using UnityEngine;

[CreateAssetMenu(fileName = "UnitColorDecorator", menuName = "Unit/UnitColorDecorator")]
public class UnitColorDecorator : UnitDecorator
{
    [SerializeField] private Color _color;
    [SerializeField] private float _health;
    [SerializeField] private float _attackDamage;
    [SerializeField] private float _attackSpeed;
    [SerializeField] private float _moveSpeed;
    
    public override void Decorate(ref UnitStats unitStats)
    {
        unitStats.Color = _color;
        unitStats.MaxHealth += _health;
        unitStats.AttackDamage += _attackDamage;
        unitStats.AttackSpeed += _attackSpeed;
        unitStats.MaxSpeed += _moveSpeed;
    }
}