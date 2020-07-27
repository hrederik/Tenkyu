using UnityEngine;
using System.Collections.Generic;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private float _delay;
    [SerializeField] private PlatformRotator _rotator;
    [SerializeField] private PlayerMagnet _playerMagnet;
    [SerializeField] private Platform[] _platforms;
    private PlatformsIterator _iterator;
    private Vector3 _lastPosition;

    private void OnEnable()
    {
        _iterator = new PlatformsIterator(_platforms);

        foreach (Platform platform in _platforms)
        {
            platform.PlatformExit += StartGeneration;
        }
    } 

    private void OnDisable()
    {
        foreach (Platform platform in _platforms)
        {
            platform.PlatformExit -= StartGeneration;
        }
    }

    public void StartGeneration()
    {
        StartCoroutine(StartDelayGeneration(_iterator.Current));
        ChangeTargetPlatform(_iterator.MoveNext());
    }

    private void ChangeTargetPlatform(Platform target)
    {
        _rotator.ChangeRotatableObject(target.transform);
        _playerMagnet.Enable(target.MagnetPoint);
    }

    private IEnumerator<WaitForSeconds> StartDelayGeneration(Platform target)
    {
        yield return new WaitForSeconds(_delay);
        Generate(target);
    }

    private void Generate(Platform target)
    {
        _lastPosition = target.Move(_lastPosition);        
    }
}