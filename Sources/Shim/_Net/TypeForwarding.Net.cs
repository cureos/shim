// Type forwarded to .Net framework

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.ServiceModel;
using System.Windows;

// System.Diagnostics.CodeAnalysis
[assembly: TypeForwardedTo(typeof(ExcludeFromCodeCoverageAttribute))]

// System.ServiceModel
[assembly: TypeForwardedTo(typeof(CallbackBehaviorAttribute))]
[assembly: TypeForwardedTo(typeof(ConcurrencyMode))]

// System.Windows
[assembly: TypeForwardedTo(typeof(Point))]
