namespace GeneralDomain.UtilityTypes;

public record NonEmptyString
{
    public string Value { get; }

    private NonEmptyString(string value) => Value = value;

    public static NonEmptyString Create(string value) =>
        string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)
            ? throw new ArgumentOutOfRangeException(nameof(value), "Value cannot be empty or white spaces only")
            : new(value);

    public override string ToString() => Value;

    public static implicit operator string(NonEmptyString value) => value.Value;
}

