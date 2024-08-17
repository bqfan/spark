﻿/*
 * Copyright (c) 2021-2024, Incendi (info@incendi.no) and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/spark/stu3/master/LICENSE
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