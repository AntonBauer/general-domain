namespace GeneralDomain.UtilityTypes;

public record NonEmptyString
{
    public string Value { get; }

    private NonEmptyString(string value) => Value = value;

    public static Validation<string, NonEmptyString> Create(string value) =>
        string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)
            ? Validation<string, NonEmptyString>.Fail(["Value cannot be empty"])
            : Validation<string, NonEmptyString>.Success(new(value));

    public override string ToString() => Value;

    public static implicit operator string(NonEmptyString value) => value.Value;
}

