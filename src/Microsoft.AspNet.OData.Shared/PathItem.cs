﻿// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System.Collections.Generic;

namespace Microsoft.AspNet.OData
{
    /// <summary>
    /// Class to hold the PathItem Name and its keyproperties
    /// </summary>
    public class PathItem
    {
        /// <summary>
        /// Name of the Path Item (eg: entity name, entity set name)
        /// </summary>
        public string Name { internal set; get; }

        /// <summary>
        /// Whether the PathItem is a cast segment
        /// </summary>
        public bool IsCastType { internal set; get; }

        /// <summary>
        /// If the item is a cast segment, Name of the Path Item (eg: derived entity name, entity set name)
        /// </summary>
        public string CastTypeName { internal set; get; }

        /// <summary>
        /// List of Key properties of that entity
        /// </summary>
        public Dictionary<string, object> KeyProperties { internal set; get; }
    }
}