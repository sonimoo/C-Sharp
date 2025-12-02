sealed class InputLibraryFilter
{
    private readonly LibraryFilter _impl;

    public InputLibraryFilter(LibraryFilter impl)
    {
        _impl = impl;
    }

    public bool Status(string? str)
    {
        if (string.IsNullOrWhiteSpace(str))
            return false;

        bool ok = Enum.TryParse(
            value: str,
            ignoreCase: true,
            out BookState state);

        if (!ok)
            return false;

        _impl.State = state;
        return true;
    }

    public void NameContains(string? str)
    {
        if (string.IsNullOrWhiteSpace(str))
            str = null;

        _impl.NameContains = str;
    }

    public void NameNotContains(string? str)
    {
        if (string.IsNullOrWhiteSpace(str))
            str = null;

        _impl.NameNotContains = str;
    }

    public void Author(string? str)
    {
        if (string.IsNullOrWhiteSpace(str))
            str = null;

        _impl.Author = str;
    }

    public void NameStartsWith(string? str)
    {
        if (string.IsNullOrWhiteSpace(str))
            str = null;

        _impl.NameStartsWith = str;
    }
}
