// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> Describes a closed polygon configuration. </summary>
    public partial class NamedPolygonString : NamedPolygonBase
    {
        /// <summary> Initializes a new instance of NamedPolygonString. </summary>
        /// <param name="name"> Polygon name. Must be unique within the node. </param>
        /// <param name="polygon"> Point coordinates for the polygon. Example: &apos;[[0.3, 0.2],[0.9, 0.8],[0.7, 0.6]]&apos;. Each point is expressed as [LEFT, TOP] coordinate ratios ranging from 0.0 to 1.0, where [0,0] is the upper-left frame corner and [1, 1] is the bottom-right frame corner. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="polygon"/> is null. </exception>
        public NamedPolygonString(string name, string polygon) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(polygon, nameof(polygon));

            Polygon = polygon;
            Type = "#Microsoft.VideoAnalyzer.NamedPolygonString";
        }

        /// <summary> Initializes a new instance of NamedPolygonString. </summary>
        /// <param name="type"> The Type discriminator for the derived types. </param>
        /// <param name="name"> Polygon name. Must be unique within the node. </param>
        /// <param name="polygon"> Point coordinates for the polygon. Example: &apos;[[0.3, 0.2],[0.9, 0.8],[0.7, 0.6]]&apos;. Each point is expressed as [LEFT, TOP] coordinate ratios ranging from 0.0 to 1.0, where [0,0] is the upper-left frame corner and [1, 1] is the bottom-right frame corner. </param>
        internal NamedPolygonString(string type, string name, string polygon) : base(type, name)
        {
            Polygon = polygon;
            Type = type ?? "#Microsoft.VideoAnalyzer.NamedPolygonString";
        }

        /// <summary> Point coordinates for the polygon. Example: &apos;[[0.3, 0.2],[0.9, 0.8],[0.7, 0.6]]&apos;. Each point is expressed as [LEFT, TOP] coordinate ratios ranging from 0.0 to 1.0, where [0,0] is the upper-left frame corner and [1, 1] is the bottom-right frame corner. </summary>
        public string Polygon { get; set; }
    }
}
