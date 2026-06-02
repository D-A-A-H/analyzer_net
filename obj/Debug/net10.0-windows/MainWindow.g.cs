#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B2B412F54893F9EEA75EF091A5959F6F5DFA1F64"

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace NetworkAnalyzer {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lbInterfaces;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtName;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtIp;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtMask;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtMac;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtStatus;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtTypeSpeed;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtUrl;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lbUrlResults;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtDnsInfo;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtAddressType;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView lvHistory;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "10.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/NetworkAnalyzer;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "10.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.lbInterfaces = ((System.Windows.Controls.ListBox)(target));
            
            #line 25 "..\..\..\MainWindow.xaml"
            this.lbInterfaces.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lbInterfaces_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.txtIp = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.txtMask = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.txtMac = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.txtStatus = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.txtTypeSpeed = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.txtUrl = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            
            #line 82 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnAnalyze_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 85 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnPing_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.lbUrlResults = ((System.Windows.Controls.ListBox)(target));
            return;
            case 12:
            this.txtDnsInfo = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 13:
            this.txtAddressType = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 14:
            
            #line 108 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnClearHistory_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 110 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btnRefresh_Click);
            
            #line default
            #line hidden
            return;
            case 16:
            this.lvHistory = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

