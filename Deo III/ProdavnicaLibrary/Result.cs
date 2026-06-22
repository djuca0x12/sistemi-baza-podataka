namespace ProdavnicaLibrary;

// struktura! za prenošenje grešaka iz jedne u drugu metodu
// na osnovu param zaključujemo da li je došlo do greške?
public readonly struct Result<TValue, TError>
{
    // došlo do greške?
    public bool IsError { get; }
    // invertuje prethodni
    public bool IsSuccess => !IsError;

    // generički tip: vraćamo podatke različitih tipova (bool, entitet...)
    public TValue Data
    {
        get
        {
            return _value ?? default!;
        }
    }
    // može i ErrorMessage
    public TError Error
    {
        get
        {
            return _error ?? default!;
        }
    }

    private readonly TValue? _value;
    private readonly TError? _error;

    private Result(TValue value)
    {
        IsError = false;
        _value = value;
        _error = default;
    }

    private Result(TError error)
    {
        IsError = true;
        _error = error;
        _value = default;
    }

    // implicitna konverzija: na osnovu prosleđenog tipa i broja parametara
    // poziva odg. konstruktor
    public static implicit operator Result<TValue, TError>(TValue value) => new(value);

    public static implicit operator Result<TValue, TError>(TError error) => new(error);

    // vraćamo Result -> .Data, .IsError...
    // naš tip deli na tri vrednosti na zasebne promenljive u kontroleru
    public void Deconstruct(out bool isError, out TValue? value, out TError? error)
    {
        isError = IsError;
        value = _value;
        error = _error;
    }
}
