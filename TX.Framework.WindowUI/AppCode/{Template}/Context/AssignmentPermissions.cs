#region COPYRIGHT
//
//     THIS IS GENERATED BY TEMPLATE
//     
//     AUTHOR  :     ROYE
//     DATE       :     2010
//
//     COPYRIGHT (C) 2010, TIANXIAHOTEL TECHNOLOGIES CO., LTD. ALL RIGHTS RESERVED.
//
#endregion

using System;
using System.Collections.Generic;
using System.Text;

namespace System.Text.Template
{
    [Flags]
    public enum AssignmentPermissions
    {
        None = 0, 
        ExistingVariable = 1, 
        NewVariable = 2, 
        Variable = 3, 
        Property = 4, 
        Indexer = 8, 
        All = 15
    }
}