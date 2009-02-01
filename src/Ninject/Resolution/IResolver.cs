﻿using System;
using System.Collections.Generic;
using Ninject.Activation;
using Ninject.Infrastructure.Components;
using Ninject.Resolution.Strategies;

namespace Ninject.Resolution
{
	public interface IResolver : INinjectComponent
	{
		IList<IResolutionStrategy> Strategies { get; }
		object Resolve(IContext context);
	}
}