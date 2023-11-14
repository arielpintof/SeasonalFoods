﻿using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using Ardalis.SmartEnum;
using static System.StringComparer;

namespace SeasonalFoods.Enums;

[SuppressMessage("ReSharper", "ReturnTypeCanBeEnumerable.Global")]
public interface IEnum<out T, TEnum>
    where T : SmartEnum<T>, IEnum<T, TEnum>
    where TEnum : struct, System.Enum, IConvertible
{
    private static readonly IReadOnlyCollection<TEnum> Tokens = 
        System.Enum.GetValues<TEnum>().ToImmutableList();

    string ReadableName { get; }

    static IReadOnlyCollection<T> Values() => SmartEnum<T>.List;

    static IReadOnlyCollection<T> NonNullValues() => Values().Skip(1).ToImmutableList();

    static IReadOnlyDictionary<TEnum, T> TokenDictionary() =>
        Tokens.Zip(Values(), (k, v) => new { Key = k, Value = v }).ToImmutableDictionary(e => e.Key, e => e.Value);

    static IReadOnlyDictionary<string, T> ReadableNameDictionary() =>
        TokenDictionary().ToImmutableDictionary(e => e.Value.ReadableName, e => e.Value,
            StringComparer.InvariantCultureIgnoreCase);

    static T FromToken(TEnum token) =>
        TokenDictionary().TryGetValue(token, out var value) ? value : throw new KeyNotFoundException();

    static T FromReadableName(string readableName) =>
        ReadableNameDictionary().TryGetValue(readableName, out var value) ? value : throw new KeyNotFoundException();
}