﻿using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Android.App;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Weavy.Android")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("Weavy.Android")]
[assembly: AssemblyCopyright("Copyright ©  2014")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: ComVisible(false)]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

// Add some common permissions, these can be removed if not needed
[assembly: UsesPermission(Android.Manifest.Permission.Internet)]
[assembly: UsesPermission(Android.Manifest.Permission.WriteExternalStorage)]
[assembly: UsesPermission(Android.Manifest.Permission.Vibrate)]
// Default 
[assembly: UsesPermission("com.android.launcher.permission.READ_SETTINGS")]
[assembly: UsesPermission("com.android.launcher.permission.WRITE_SETTINGS")]
[assembly: UsesPermission("com.android.launcher.permission.INSTALL_SHORTCUT")]
[assembly: UsesPermission("com.android.launcher.permission.UNINSTALL_SHORTCUT")]

// Apex 
[assembly: UsesPermission("com.anddoes.launcher.permission.UPDATE_COUNT")]

// HTC 
[assembly: UsesPermission("com.htc.launcher.permission.READ_SETTINGS")]
[assembly: UsesPermission("com.htc.launcher.permission.UPDATE_SHORTCUT")]

// Samsung 
[assembly: UsesPermission("com.sec.android.provider.badge.permission.READ")]
[assembly: UsesPermission("com.sec.android.provider.badge.permission.WRITE")]

// Sony
[assembly: UsesPermission("com.sonyericsson.home.permission.BROADCAST_BADGE")]
[assembly: UsesPermission("com.sonymobile.home.permission.PROVIDER_INSERT_BADGE")]
