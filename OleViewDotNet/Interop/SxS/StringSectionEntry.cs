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

namespace OleViewDotNet.Interop.SxS;

internal class StringSectionEntry<T>
{
    public string Key { get; }
    public T Entry { get; }
    public int Offset { get; }
    public ActCtxAssemblyRoster RosterEntry { get; }

    public StringSectionEntry(string key, T entry, int offset, ActCtxAssemblyRoster roster_entry)
    {
        Key = key;
        Entry = entry;
        Offset = offset;
        RosterEntry = roster_entry;
    }
}
