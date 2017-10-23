﻿// See the LICENSE file in the project root for more information.

using Microsoft.AspNetCore.Http;
using ILSpy.Host.Providers;

namespace ILSpy.Host
{
    public abstract class BaseMiddleware
    {
        protected readonly RequestDelegate _next;
        protected readonly IDecompilationProvider _decompilationProvider;

        public abstract string EndPoint { get; }

        public BaseMiddleware(RequestDelegate next, IDecompilationProvider decompilationProvider)
        {
            _next = next;
            _decompilationProvider = decompilationProvider;
        }
    }
}
