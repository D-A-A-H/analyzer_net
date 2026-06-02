using System.Windows;
using System.Windows.Controls;
using System.Linq;
using NetworkAnalyzer.Models;
using NetworkAnalyzer.Services;

namespace NetworkAnalyzer
{
    public partial class MainWindow : Window
    {
        private readonly NetworkService _networkService;
        private readonly UrlService _urlService;
        private System.Collections.Generic.List<NetworkInterfaceInfo> _interfaces;

        public MainWindow()
        {
            InitializeComponent();
            _networkService = new NetworkService();
            _urlService = new UrlService();
            _interfaces = new System.Collections.Generic.List<NetworkInterfaceInfo>();
            LoadNetworkInterfaces();
        }

        private void LoadNetworkInterfaces()
        {
            _interfaces = _networkService.GetAllNetworkInterfaces();
            lbInterfaces.ItemsSource = _interfaces;

            if (_interfaces.Count > 0)
                lbInterfaces.SelectedIndex = 0;
        }

        private void lbInterfaces_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lbInterfaces.SelectedItem is NetworkInterfaceInfo info)
            {
                txtName.Text = info.Description;
                txtIp.Text = info.IpAddress;
                txtMask.Text = info.SubnetMask;
                txtMac.Text = info.MacAddress;
                txtStatus.Text = info.Status.ToString();
                txtTypeSpeed.Text = $"{info.Type} ({info.Speed / 1_000_000} Мбит/с)";
                txtAddressType.Text = $"Тип адреса: {info.AddressType}";
            }
        }

        private async void btnAnalyze_Click(object sender, RoutedEventArgs e)
        {
            string url = txtUrl.Text.Trim();
            if (string.IsNullOrEmpty(url))
            {
                MessageBox.Show("Введите URL", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            var parsed = _urlService.ParseUrl(url);
            lbUrlResults.ItemsSource = parsed.Select(kvp => $"{kvp.Key}: {kvp.Value}").ToList();

            string host = parsed.ContainsKey("Хост") ? parsed["Хост"] : url;
            bool isAvailable = await _networkService.PingHostAsync(host);
            _urlService.AddToHistory(url, isAvailable);
            lvHistory.ItemsSource = _urlService.GetHistory();

            txtDnsInfo.Text = "DNS: Получение...";
            var dns = await _networkService.GetDnsInfoAsync(host);
            txtDnsInfo.Text = $"DNS: {string.Join(", ", dns)}";

            txtAddressType.Text = $"Тип адреса: {_networkService.GetAddressType(host)}";
        }

        private async void btnPing_Click(object sender, RoutedEventArgs e)
        {
            string url = txtUrl.Text.Trim();
            if (string.IsNullOrEmpty(url))
            {
                MessageBox.Show("Введите URL", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            var parsed = _urlService.ParseUrl(url);
            string host = parsed.ContainsKey("Хост") ? parsed["Хост"] : url;

            bool result = await _networkService.PingHostAsync(host);
            MessageBox.Show($"Ping {host}: {(result ? "Доступен" : "Недоступен")}", 
                           "Результат Ping", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void btnClearHistory_Click(object sender, RoutedEventArgs e)
        {
            _urlService.ClearHistory();
            lvHistory.ItemsSource = null;
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            LoadNetworkInterfaces();
        }
    }
}