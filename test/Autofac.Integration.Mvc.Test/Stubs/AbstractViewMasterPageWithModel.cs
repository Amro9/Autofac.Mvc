// Copyright (c) Autofac Project. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace Autofac.Integration.Mvc.Test.Stubs;

public abstract class AbstractViewMasterPageWithModel<T> : ViewMasterPage<T>
{
    public Dependency Dependency { get; set; }
}