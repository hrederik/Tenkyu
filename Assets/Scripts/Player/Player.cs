using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;

    public void SetVelocity(Vector3 velocity)
    {
        _rigidbody.velocity = velocity;
    }

    public void Stop()
    {
        SetVelocity(Vector3.zero);
    }
}