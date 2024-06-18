﻿//    This file is part of OleViewDotNet.
//    Copyright (C) James Forshaw 2019
//
//    OleViewDotNet is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    OleViewDotNet is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with OleViewDotNet.  If not, see <http://www.gnu.org/licenses/>.

using System.Runtime.InteropServices;

namespace OleViewDotNet.Interop.SxS;

[StructLayout(LayoutKind.Sequential)]
internal struct ACTIVATION_CONTEXT_DATA_ASSEMBLY_ROSTER_ENTRY
{
    public ACTIVATION_CONTEXT_DATA_ASSEMBLY_ROSTER_ENTRY_FLAGS Flags;
    public uint PseudoKey;                // case-insentively-hashed assembly name
    public int AssemblyNameOffset;       // from ACTIVATION_CONTEXT_DATA base
    public int AssemblyNameLength;       // length in bytes
    public int AssemblyInformationOffset; // from ACTIVATION_CONTEXT_DATA base to ACTIVATION_CONTEXT_DATA_ASSEMBLY_INFORMATION
    public int AssemblyInformationLength; // length in bytes
}
