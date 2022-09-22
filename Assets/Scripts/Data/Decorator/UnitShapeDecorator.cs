using UnityEngine;

[CreateAssetMenu(fileName = "UnitShapeDecorator", menuName = "Unit/UnitShapeDecorator")]
public class UnitShapeDecorator : UnitDecorator
{
    [SerializeField] private Mesh _mesh;
    [SerializeField] private float _health;
    [SerializeField] private float _attackDamage;

    public override void Decorate(ref UnitStats unitStats)
    {
        unitStats.Mesh = _mesh;
        unitStats.MaxHealth += _health;
        unitStats.AttackDamage += _attackDamage;
    }
}