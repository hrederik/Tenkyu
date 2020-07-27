using UnityEngine;

public class TargetFollowing : MonoBehaviour
{
    [SerializeField] private Transform _target;
    private Transform _follower;

    [SerializeField] private float _yOffset = 0.0f;

    private void Start()
    {
        _follower = GetComponent<Transform>();
    }

    private void Update()
    {
        _follower.position = new Vector3(_target.position.x, _target.position.y + _yOffset, _follower.position.z);
    }
}
