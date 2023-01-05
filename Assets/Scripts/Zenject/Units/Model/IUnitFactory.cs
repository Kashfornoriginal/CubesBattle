using UnityEngine;

public interface IUnitFactory
{
    void Load();
    void Create(Vector3 enemyPosition);
}