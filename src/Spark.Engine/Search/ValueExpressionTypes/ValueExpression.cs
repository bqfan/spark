﻿/* 
 * Copyright (c) 2015-2018, Firely (info@fire.ly) and contributors
 * Copyright (c) 2020-2024, Incendi (info@incendi.no) and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * SPDX-License-Identifier: BSD-3-Clause
 */

namespace Spark.Search
{
    public abstract class ValueExpression : Expression
    {
        public string ToUnescapedString()
        {
            var value = this;
            if (value is UntypedValue untyped)
            {
                value = untyped.AsStringValue();

                return StringValue.UnescapeString(value.ToString());
            }
            return value.ToString();
        }
    }
}
