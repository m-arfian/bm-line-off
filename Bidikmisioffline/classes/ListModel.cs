using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bidikmisioffline.classes
{
    class ListModel
    {
        public string Text { get; set; }
        public string Value { get; set; }

        public ListModel(string t, string v)
        {
            Text = t;
            Value = v;
        }

        public ListModel(string t)
        {
            Text = t;
            Value = t;
        }
    }
}
