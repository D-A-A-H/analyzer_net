using System;
using System.Collections.Generic;
using System.Linq;
using NetworkAnalyzer.Models;

namespace NetworkAnalyzer.Services
{
    public class UrlService
    {
        private readonly List<UrlHistoryItem> _history = new();

        public Dictionary<string, string> ParseUrl(string url)
        {
            var result = new Dictionary<string, string>();

            if (!Uri.TryCreate(url, UriKind.Absolute, out Uri? uri) || uri == null)
            {
                result["Ошибка"] = "Некорректный URL";
                return result;
            }

            result["Схема (протокол)"] = uri.Scheme;
            result["Хост"] = uri.Host;
            result["Порт"] = uri.IsDefaultPort ? "По умолчанию" : uri.Port.ToString();
            result["Путь"] = uri.AbsolutePath;
            result["Параметры запроса"] = string.IsNullOrEmpty(uri.Query) ? "Нет" : uri.Query;
            result["Фрагмент"] = string.IsNullOrEmpty(uri.Fragment) ? "Нет" : uri.Fragment;
            result["Пользователь"] = string.IsNullOrEmpty(uri.UserInfo) ? "Нет" : uri.UserInfo;

            return result;
        }

        public void AddToHistory(string url, bool isAvailable)
        {
            _history.Add(new UrlHistoryItem(url, isAvailable));
        }

        public List<UrlHistoryItem> GetHistory()
        {
            return _history.OrderByDescending(h => h.CheckedAt).ToList();
        }

        public void ClearHistory()
        {
            _history.Clear();
        }
    }
}
