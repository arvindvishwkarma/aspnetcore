// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

#nullable disable

using Microsoft.AspNetCore.Analyzers.RouteEmbeddedLanguage;
using Microsoft.AspNetCore.Analyzers.RouteEmbeddedLanguage.Common;

namespace Microsoft.AspNetCore.Analyzers.RouteEmbeddedLanguage;

internal abstract class NewRoutePatternNode : EmbeddedSyntaxNode<NewRoutePatternKind, NewRoutePatternNode>
{
    protected NewRoutePatternNode(NewRoutePatternKind kind) : base(kind)
    {
    }

    public abstract void Accept(INewRoutePatternNodeVisitor visitor);
}
