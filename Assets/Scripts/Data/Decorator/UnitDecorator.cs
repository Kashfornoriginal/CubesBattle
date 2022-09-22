using UnityEngine;

public abstract class UnitDecorator : ScriptableObject
{
   public abstract void Decorate(ref UnitStats unitStats);
}
