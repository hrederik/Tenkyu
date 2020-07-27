using UnityEngine;

public class PlatformRotator : MonoBehaviour
{
    [SerializeField] private UserInput _userInput;
    [SerializeField] private Transform _rotatableObject;
    [SerializeField] private float _rotationSpeed = 1.0f;

    private void OnEnable()
    {
        _userInput.LevelDragged += OnLevelDrag;
    }

    private void OnDisable()
    {
        _userInput.LevelDragged -= OnLevelDrag;
    }

    public void OnLevelDrag(Vector2 delta)
    {
        delta.Normalize();
        delta *= _rotationSpeed;        
        _rotatableObject.Rotate(delta.y, 0, -delta.x);
    }

    public void ChangeRotatableObject(Transform target)
    {
        _rotatableObject = target;
    }
}