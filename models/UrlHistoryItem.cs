using System;

namespace NetworkAnalyzer.Models
{
    public class UrlHistoryItem
    {
        public string Url { get; set; } = string.Empty;
        public DateTime CheckedAt { get; set; }
        public bool IsAvailable { get; set; }

        public UrlHistoryItem(string url, bool isAvailable)
        {
            Url = url;
            CheckedAt = DateTime.Now;
            IsAvailable = isAvailable;
        }
    }
}