using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MytinyurlAPI.Data
{
    public class MockBD
    {
        public static ConcurrentDictionary<string, string> URLS = new ConcurrentDictionary<string, string>();

        public static void clearCache()
        {
            URLS.Clear();
        }
    }
}