using UnityEngine;
using UnityEngine.Events;

public class PlayerTrigger : MonoBehaviour
{
    [SerializeField] private UnityEvent _playerInteracted;
    public event UnityAction PlayerInteracted
    {
        add => _playerInteracted.AddListener(value);
        remove => _playerInteracted.RemoveListener(value);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Player>())
        {
            _playerInteracted?.Invoke();
        }
    }
}