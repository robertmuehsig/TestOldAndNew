// This file provides the "missing" type in connection with the C# 11 required members feature.
// See also CompilerFeatureRequiredAttribute.cs and SetsRequiredMembersAttribute

// Error that is issued when this class is missing:
// - Error CS0656: Missing compiler required member 'System.Runtime.CompilerServices.RequiredMemberAttribute..ctor'

// Example usages:
// - public class MyClass { public required string MyString { get; init; } }

// Source file in dotnet/runtime repository:
// https://github.com/dotnet/runtime/blob/fdd104ec5e1d0d2aa24a6723995a98d0124f724b/src/libraries/System.Private.CoreLib/src/System/Runtime/CompilerServices/RequiredMemberAttribute.cs

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

#if !NET7_0_OR_GREATER

namespace System.Runtime.CompilerServices
{
    /// <summary>Specifies that a type has required members or that a member is required.</summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
// #if SYSTEM_PRIVATE_CORELIB
    public
// #else
//     internal
// #endif
        sealed class RequiredMemberAttribute : Attribute
    { }
}

#endif
