using System;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle("PMSX - Pathology management system")]
[assembly: AssemblyDescription("Pathology management system")]
#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
[assembly: AssemblyVersion("1.5.1")]
#else
[assembly: AssemblyConfiguration("Release")]
[assembly: AssemblyVersion("1.5.1.*")]
#endif
[assembly: AssemblyFileVersion("1.5.1")]
[assembly: AssemblyCompany("Daomtthuan")]
[assembly: AssemblyProduct("PMSX")]
[assembly: AssemblyCopyright("Copyright © 2020 Daomtthuan")]
[assembly: AssemblyTrademark("Daomtthuan")]
[assembly: AssemblyCulture("")]
[assembly: ComVisible(true)]
[assembly: Guid("9006f149-aa49-4b8e-ba69-386d945fa738")]
[assembly: NeutralResourcesLanguage("vi-VN")]