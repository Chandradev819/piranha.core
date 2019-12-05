/*
 * Copyright (c) 2019 Håkan Edling
 *
 * This software may be modified and distributed under the terms
 * of the MIT license.  See the LICENSE file for details.
 *
 * https://github.com/piranhacms/piranha.core
 *
 */

using Microsoft.Extensions.DependencyInjection;

namespace Piranha
{
    /// <summary>
    /// Service builder for simple application startup.
    /// </summary>
    public class PiranhaServiceBuilder
    {
        /// <summary>
        /// The inner Service collection.
        /// </summary>
        public readonly IServiceCollection Services;

        /// <summary>
        /// Default constructor.
        /// </summary>
        /// <param name="builder">The current application builder</param>
        public PiranhaServiceBuilder(IServiceCollection services)
        {
            Services = services;
        }
    }
}