// <copyright file="AssemblyInfo.cs" company="MS Internal">Copyright (c) MS 2015</copyright>
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

// System.Security
[assembly: SecurityRules(SecurityRuleSet.Level1)]

// System.Reflection
[assembly: AssemblyTitle("MS.BugBot Pex Tests")]

// System.Runtime.InteropServices
[assembly: ComVisible(false)]
[assembly: Guid("f9f15ce4-be38-41d7-bbfa-6abd8a3cd4a0")]

// System
[assembly: CLSCompliant(false)]

// System.Runtime.CompilerServices
[assembly: InternalsVisibleTo("Microsoft.Pex")]

