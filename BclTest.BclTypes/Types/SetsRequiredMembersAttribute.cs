// This file provides the "missing" type in connection with the C# 11 required members feature.
// See also CompilerFeatureRequiredAttribute.cs and RequiredMemberAttribute.cs

// Error that is issued when this class is missing:
// - Error CS0656: Missing compiler required member 'System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute..ctor'

// Example usages:
// - public class MyClass { public required string MyString { get; init; } }

// Source file in dotnet/runtime repository:
// https://github.com/dotnet/runtime/blob/ca3936bfadce33f58c17c30b91f67881f257fce1/src/libraries/System.Private.CoreLib/src/System/Diagnostics/CodeAnalysis/SetsRequiredMembersAttribute.cs

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

#if !NET7_0_OR_GREATER

namespace System.Diagnostics.CodeAnalysis
{
    /// <summary>
    /// Specifies that this constructor sets all required members for the current type, and callers
    /// do not need to set any required members themselves.
    /// </summary>
    [AttributeUsage(AttributeTargets.Constructor, AllowMultiple = false, Inherited = false)]
// #if SYSTEM_PRIVATE_CORELIB
    public
// #else
//     internal
// #endif
        sealed class SetsRequiredMembersAttribute : Attribute
    { }
}

#endif
