using UnityEngine;
using UnityEngine.Events;

public class Platform : MoveableObject
{
    [SerializeField] private Transform _magnetPoint;
    [SerializeField] private PlayerTrigger _exit;
    [SerializeField] private float _resetRotationDelay = 1.0f;

    public Transform MagnetPoint => _magnetPoint;
    public event UnityAction PlatformExit
    {
        add => _exit.PlayerInteracted += value;
        remove => _exit.PlayerInteracted -= value;
    }

    protected override void OnMoved()
    {
        ResetRotation();
    }

    private void ResetRotation()
    {
        transform.eulerAngles = Vector3.zero;
    }
}