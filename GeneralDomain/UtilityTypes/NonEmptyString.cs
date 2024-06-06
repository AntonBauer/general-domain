using CSharpFunctionalExtensions;

namespace GeneralDomain.UtilityTypes;

public record NonEmptyString
{
    public string Value { get; }

    private NonEmptyString(string value) => Value = value;

    public static Result<NonEmptyString> Create(string value) =>
        Result.SuccessIf<NonEmptyString>(() => string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value),
                                         new(value),
                                         "Value cannot be empty");

    public override string ToString() => Value;

    public static implicit operator string(NonEmptyString value) => value.Value;
}

