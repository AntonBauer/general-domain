using CSharpFunctionalExtensions;

namespace GeneralDomain.UtilityTypes;

public readonly record struct NonNegativeDouble
{
  public double Value { get; }

  private NonNegativeDouble(double value) => Value = value;

  public static Result<NonNegativeDouble> Create(double value) =>
      Result.SuccessIf<NonNegativeDouble>(() => value >= 0, new(value), "Value must be non-negative");

  public static implicit operator double(NonNegativeDouble value) => value.Value;
}