using UnityEngine;

public struct UnitStats
{
    public Mesh Mesh { get; set; }
    public Color Color { get; set; }
    public float Size { get; set; }
    public float MaxHealth { get; set; }
    public float MaxSpeed { get; set; }
    public float AttackDamage { get; set; }
    public float AttackSpeed { get; set; }

    public UnitStats(Mesh mesh, Color color, float size, float maxHealth, float maxSpeed, float attackDamage, float attackSpeed)
    {
        Mesh = mesh;
        Color = color;
        Size = size;
        MaxHealth = maxHealth;
        MaxSpeed = maxSpeed;
        AttackDamage = attackDamage;
        AttackSpeed = attackSpeed;
    }
}
