using UnityEngine;

public abstract class MoveableObject : MonoBehaviour
{
    [SerializeField] private Vector3 _offset;
    
    public Vector3 Move(Vector3 lastPosition)
    {
        Vector3 newPosition = lastPosition + _offset;
        transform.localPosition = newPosition;

        OnMoved();
        return newPosition;
    }

    protected abstract void OnMoved();
}
