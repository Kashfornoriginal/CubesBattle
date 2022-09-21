using UnityEngine;

public interface IEnemyMover
{
    public void MoveTo(Vector3 moveTarget, float moveSpeed);
}
