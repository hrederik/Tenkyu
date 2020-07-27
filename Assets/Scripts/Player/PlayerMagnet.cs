using System.Collections;
using UnityEngine;

public class PlayerMagnet : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private Transform _target;
    [SerializeField] private float _power = 1.0f;
    [SerializeField] private float _delay = 1.0f;
    private bool _isEnable;

    private void FixedUpdate()
    {
        if (_isEnable)
        {
            Vector3 direction = (_target.position - _player.transform.position).normalized;
            _player.SetVelocity(direction * _power);
        }
    }

    public void Enable(Transform target)
    {
        StartCoroutine(Activate(target));
    }

    public void Disable()
    {
        _isEnable = false;
    }

    private IEnumerator Activate(Transform target)
    {
        yield return new WaitForSeconds(_delay);

        _target = target;
        _isEnable = true;
    }
}
