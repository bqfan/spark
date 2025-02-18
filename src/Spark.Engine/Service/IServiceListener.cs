﻿/*
 * Copyright (c) 2015-2018, Firely <info@fire.ly>
 * Copyright (c) 2021-2024, Incendi <info@incendi.no>
 *
 * SPDX-License-Identifier: BSD-3-Clause
 */

using System;
using System.Threading.Tasks;
using Spark.Engine.Core;

namespace Spark.Service;

public interface IServiceListener
{
    Task InformAsync(Uri location, Entry interaction);
}