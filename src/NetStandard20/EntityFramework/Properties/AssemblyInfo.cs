// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

using System.Reflection;

#if !NET40

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

#endif

//[assembly: AssemblyTitle("Z.EntityFramework.Classic")]
//[assembly: AssemblyDescription("Z.EntityFramework.Classic.dll")]
[assembly: AssemblyDefaultAlias("Z.EntityFramework.Classic.dll")]

#if !NET40

// In EF 4.1-4.3, these attributes were all in the System.ComponentModel.DataAnnotations
// namespace of Z.EntityFramework.Classic.dll.
//
// In EF 5+ for .NET 4, all but MaxLength and MinLength were moved to the
// System.ComponentModel.DataAnnotations.Schema namespace and remained in Z.EntityFramework.Classic.dll.
//
// In .NET 4.5, these attributes were moved into the .NET Framework as part of the
// System.ComponentModel.DataAnnotations.dll assembly. Hence in EF 5+ for .NET 4.5 and later,
// the type forwarding below forwards from the Z.EntityFramework.Classic.dll for EF 5+ on .NET 4 to
// System.ComponentModel.DataAnnotations.dll in .NET 4.5 or later.

[assembly: TypeForwardedTo(typeof(MaxLengthAttribute))]
[assembly: TypeForwardedTo(typeof(MinLengthAttribute))]
[assembly: TypeForwardedTo(typeof(ColumnAttribute))]
[assembly: TypeForwardedTo(typeof(ComplexTypeAttribute))]
[assembly: TypeForwardedTo(typeof(DatabaseGeneratedAttribute))]
[assembly: TypeForwardedTo(typeof(DatabaseGeneratedOption))]
[assembly: TypeForwardedTo(typeof(ForeignKeyAttribute))]
[assembly: TypeForwardedTo(typeof(InversePropertyAttribute))]
[assembly: TypeForwardedTo(typeof(NotMappedAttribute))]
[assembly: TypeForwardedTo(typeof(TableAttribute))]

#endif
