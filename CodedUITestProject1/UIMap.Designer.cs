﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      Dieser Code wurde vom Coded UI-Test-Generator generiert.
//      Version: 12.0.0.0
//
//      In dieser Datei sind spezialisierte Klassen definiert, die in einem
//      Coded UI-Test verwendet werden.
//      In dieser Datei können die erforderlichen Anpassungen vorgenommen werden.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace CodedUITestProject1
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UI-Test-Generator", "12.0.30501.0")]
    public partial class UIMap
    {
        
        /// <summary>
        /// RecordedMethod1
        /// </summary>
        public void RecordedMethod1()
        {
            #region Variable Declarations
            WinClient uIProgramManagerClient = this.UIProgramManagerWindow.UIItemWindow.UIProgramManagerClient;
            #endregion

            // Doppelklicken "Program Manager" Client
            Mouse.DoubleClick(uIProgramManagerClient, new Point(773, 458));

            // Klicken "Program Manager" Client
            Mouse.Click(uIProgramManagerClient, new Point(1179, 412));

            // Klicken "Program Manager" Client
            Mouse.Click(uIProgramManagerClient, new Point(850, 666));

            // Klicken "Program Manager" Client
            Mouse.Click(uIProgramManagerClient, new Point(660, 507));

            // Klicken "Program Manager" Client
            Mouse.Click(uIProgramManagerClient, new Point(1127, 383));
        }
        
        #region Properties
        public UIProgramManagerWindow UIProgramManagerWindow
        {
            get
            {
                if ((this.mUIProgramManagerWindow == null))
                {
                    this.mUIProgramManagerWindow = new UIProgramManagerWindow();
                }
                return this.mUIProgramManagerWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIProgramManagerWindow mUIProgramManagerWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UI-Test-Generator", "12.0.30501.0")]
    public class UIProgramManagerWindow : WinWindow
    {
        
        public UIProgramManagerWindow()
        {
            #region Suchkriterien
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Program Manager";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "Progman";
            this.WindowTitles.Add("Program Manager");
            #endregion
        }
        
        #region Properties
        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this);
                }
                return this.mUIItemWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIItemWindow mUIItemWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UI-Test-Generator", "12.0.30501.0")]
    public class UIItemWindow : WinWindow
    {
        
        public UIItemWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Suchkriterien
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "SHELLDLL_DefView";
            this.WindowTitles.Add("Program Manager");
            #endregion
        }
        
        #region Properties
        public WinClient UIProgramManagerClient
        {
            get
            {
                if ((this.mUIProgramManagerClient == null))
                {
                    this.mUIProgramManagerClient = new WinClient(this);
                    #region Suchkriterien
                    this.mUIProgramManagerClient.WindowTitles.Add("Program Manager");
                    #endregion
                }
                return this.mUIProgramManagerClient;
            }
        }
        #endregion
        
        #region Fields
        private WinClient mUIProgramManagerClient;
        #endregion
    }
}