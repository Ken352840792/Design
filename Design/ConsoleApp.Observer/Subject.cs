using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Observer
{
    /// <summary>
    /// 通知者
    /// </summary>
    interface Subject
    {
        void Notify();
        string SubjectState { get; set; }
    }
}
