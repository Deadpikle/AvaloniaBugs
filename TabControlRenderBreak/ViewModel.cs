using System.Collections.Generic;

namespace TabControlRenderBreak
{
    class ViewModel
    {
        public ViewModel()
        {
            Tabs = new List<string>() {};
        }

        public List<string> Tabs { get; set; }
    }
}
