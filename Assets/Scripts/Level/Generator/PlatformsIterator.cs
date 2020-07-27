public class PlatformsIterator : IPlatformIterator
{
    private Platform[] _platforms;
    private int _index;

    public PlatformsIterator(Platform[] platforms)
    {
        _platforms = platforms;
    }

    public Platform Current => _platforms[_index];

    public Platform MoveNext()
    {
        _index++;

        if (IsInvalidIndex())
        {
            _index = 0;
        }

        return _platforms[_index];
    }

    private bool IsInvalidIndex()
    {
        return _index >= _platforms.Length;
    }
}
