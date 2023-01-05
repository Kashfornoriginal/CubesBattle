using UnityEngine;

public class UnitsSpawner : MonoBehaviour
{
    [SerializeField] private UnitShapeDecorator[] _shapeDecorators = System.Array.Empty<UnitShapeDecorator>();
    [SerializeField] private UnitSizeDecorator[] _sizeDecorators = System.Array.Empty<UnitSizeDecorator>();
    [SerializeField] private UnitColorDecorator[] _colorDecorators = System.Array.Empty<UnitColorDecorator>();
    
    
}
