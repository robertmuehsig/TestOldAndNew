// This file provides the "missing" type in connection with the init property accessor.
// Note that record types implicitly use the init property accessor.
// Is explained in this article:
// "Using C#9 record and init property in your .NET Framework 4.x, .NET Standard and .NET Core projects"
// https://blog.ndepend.com/using-c9-record-and-init-property-in-your-net-framework-4-x-net-standard-and-net-core-projects/

// Error that is issued when this class is missing:
// - Error CS0518: Predefined type 'System.Runtime.CompilerServices.IsExternalInit' is not defined or imported

// Example usages:
// - public class MyClass { public string MyString { get; init; } }
// - public record MyRecord(string MyString);

// Source file in dotnet/runtime repository:
// https://github.com/dotnet/runtime/blob/57bfe474518ab5b7cfe6bf7424a79ce3af9d6657/src/libraries/Common/src/System/Runtime/CompilerServices/IsExternalInit.cs

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.ComponentModel;

namespace System.Runtime.CompilerServices
{
    /// <summary>
    /// Reserved to be used by the compiler for tracking metadata.
    /// This class should not be used by developers in source code.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
// #if SYSTEM_PRIVATE_CORELIB
    public
// #else
//     internal
// #endif
    static class IsExternalInit
    {
    }
}
