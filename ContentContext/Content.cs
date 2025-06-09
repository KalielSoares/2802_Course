using System;
using _2802_Course.SharedContext;

namespace _2802_Course.ContentContext;

public abstract class Content : Base
    {
        public Content(string title, string url)
        {
            Title = title;
            Url = url;
        }


        public string Title { get; set; }
        public string Url { get; set; }
    }
