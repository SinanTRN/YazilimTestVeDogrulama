﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    public class HtmlFormatter
    {
        public string FormatAsBold(string content)
        {
            return $"<strong><{content}</strong>";
        }
    }
}
