using System.Diagnostics;

sealed class LibraryFilter
{
    private BookState _state;
    private string? _nameContains;
    private string? _nameNotContains;
    private string? _author;
    private string? _nameStartsWith;

    public BookState State
    {
        get => _state;
        set
        {
            Debug.Assert(value == BookState.Any ||
                         value == BookState.Free ||
                         value == BookState.Taken);

            _state = value;
        }
    }

    public string? NameContains
    {
        get => _nameContains;
        set
        {
            Debug.Assert(value != "");
            _nameContains = value;
        }
    }

    public string? NameNotContains
    {
        get => _nameNotContains;
        set
        {
            Debug.Assert(value != "");
            _nameNotContains = value;
        }
    }

    public string? Author
    {
        get => _author;
        set
        {
            Debug.Assert(value != "");
            _author = value;
        }
    }

    public string? NameStartsWith
    {
        get => _nameStartsWith;
        set
        {
            Debug.Assert(value != "");
            _nameStartsWith = value;
        }
    }
}
