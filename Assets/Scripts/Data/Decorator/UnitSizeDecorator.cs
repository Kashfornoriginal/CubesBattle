using UnityEngine;

[CreateAssetMenu(fileName = "UnitSizeDecorator", menuName = "Unit/UnitSizeDecorator")]
public class UnitSizeDecorator : UnitDecorator
{
    [SerializeField] private float _size;
    [SerializeField] private float _health;

    public override void Decorate(ref UnitStats unitStats)
    {
        unitStats.Size = _size;
        unitStats.MaxHealth += _health;
    }
}