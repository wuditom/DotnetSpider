﻿using System.Net;

namespace DotnetSpider.Core.Proxy
{
	public class SingleProxyPool : IHttpProxyPool
	{
		private UseSpecifiedUriWebProxy _proxy;

		public SingleProxyPool(UseSpecifiedUriWebProxy proxy)
		{
			_proxy = proxy;
		}

		public UseSpecifiedUriWebProxy GetProxy()
		{
			return _proxy;
		}

		public void ReturnProxy(UseSpecifiedUriWebProxy host, HttpStatusCode statusCode)
		{
		}
	}
}