﻿/*
 * Copyright (c) 2021-2024, Incendi (info@incendi.no) and contributors
 * See the file CONTRIBUTORS for details.
 *
 * SPDX-License-Identifier: BSD-3-Clause
 */

namespace Spark.Web.Services
{
    public partial class ServerMetadata
	{
        public class ResourceStat
		{
			public string ResourceName { get; set; }
			public long Count { get; set; }
		}
	}
}