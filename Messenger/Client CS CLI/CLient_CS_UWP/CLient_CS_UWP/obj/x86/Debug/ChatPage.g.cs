﻿#pragma checksum "C:\Users\SageAdvice\Desktop\mirror-messenger-mark-5-Client_CS_CLI\CLient_CS_UWP\CLient_CS_UWP\ChatPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "76858518D84248D04B853D8476755E5C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CLient_CS_UWP
{
    partial class ChatPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_FrameworkElement_HorizontalAlignment(global::Windows.UI.Xaml.FrameworkElement obj, global::Windows.UI.Xaml.HorizontalAlignment value)
            {
                obj.HorizontalAlignment = value;
            }
            public static void Set_Windows_UI_Xaml_UIElement_Visibility(global::Windows.UI.Xaml.UIElement obj, global::Windows.UI.Xaml.Visibility value)
            {
                obj.Visibility = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Panel_Background(global::Windows.UI.Xaml.Controls.Panel obj, global::Windows.UI.Xaml.Media.Brush value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Windows.UI.Xaml.Media.Brush) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.Brush), targetNullValue);
                }
                obj.Background = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_RowDefinition_Height(global::Windows.UI.Xaml.Controls.RowDefinition obj, global::Windows.UI.Xaml.GridLength value)
            {
                obj.Height = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Foreground(global::Windows.UI.Xaml.Controls.TextBlock obj, global::Windows.UI.Xaml.Media.Brush value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Windows.UI.Xaml.Media.Brush) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.Brush), targetNullValue);
                }
                obj.Foreground = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class ChatPage_obj3_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IChatPage_Bindings
        {
            private global::CLient_CS_UWP.Message dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::System.WeakReference obj3;
            private global::Windows.UI.Xaml.Controls.PersonPicture obj4;
            private global::Windows.UI.Xaml.Controls.Grid obj5;
            private global::Windows.UI.Xaml.Controls.RowDefinition obj6;
            private global::Windows.UI.Xaml.Controls.TextBlock obj7;
            private global::Windows.UI.Xaml.Controls.TextBlock obj8;
            private global::Windows.UI.Xaml.Controls.TextBlock obj9;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj3HorizontalAlignmentDisabled = false;
            private static bool isobj4VisibilityDisabled = false;
            private static bool isobj5BackgroundDisabled = false;
            private static bool isobj6HeightDisabled = false;
            private static bool isobj7TextDisabled = false;
            private static bool isobj7HorizontalAlignmentDisabled = false;
            private static bool isobj7ForegroundDisabled = false;
            private static bool isobj8HorizontalAlignmentDisabled = false;
            private static bool isobj8TextDisabled = false;
            private static bool isobj9TextDisabled = false;

            public ChatPage_obj3_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 13 && columnNumber == 30)
                {
                    isobj3HorizontalAlignmentDisabled = true;
                }
                else if (lineNumber == 22 && columnNumber == 32)
                {
                    isobj4VisibilityDisabled = true;
                }
                else if (lineNumber == 24 && columnNumber == 46)
                {
                    isobj5BackgroundDisabled = true;
                }
                else if (lineNumber == 26 && columnNumber == 40)
                {
                    isobj6HeightDisabled = true;
                }
                else if (lineNumber == 30 && columnNumber == 45)
                {
                    isobj7TextDisabled = true;
                }
                else if (lineNumber == 30 && columnNumber == 66)
                {
                    isobj7HorizontalAlignmentDisabled = true;
                }
                else if (lineNumber == 32 && columnNumber == 50)
                {
                    isobj7ForegroundDisabled = true;
                }
                else if (lineNumber == 39 && columnNumber == 36)
                {
                    isobj8HorizontalAlignmentDisabled = true;
                }
                else if (lineNumber == 39 && columnNumber == 80)
                {
                    isobj8TextDisabled = true;
                }
                else if (lineNumber == 42 && columnNumber == 52)
                {
                    isobj9TextDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 3: // ChatPage.xaml line 13
                        this.obj3 = new global::System.WeakReference((global::Windows.UI.Xaml.Controls.Grid)target);
                        break;
                    case 4: // ChatPage.xaml line 18
                        this.obj4 = (global::Windows.UI.Xaml.Controls.PersonPicture)target;
                        break;
                    case 5: // ChatPage.xaml line 23
                        this.obj5 = (global::Windows.UI.Xaml.Controls.Grid)target;
                        break;
                    case 6: // ChatPage.xaml line 26
                        this.obj6 = (global::Windows.UI.Xaml.Controls.RowDefinition)target;
                        break;
                    case 7: // ChatPage.xaml line 30
                        this.obj7 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 8: // ChatPage.xaml line 39
                        this.obj8 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 9: // ChatPage.xaml line 42
                        this.obj9 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 if (this.SetDataRoot(args.NewValue))
                 {
                    this.Update();
                 }
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                ProcessBindings(args.Item, args.ItemIndex, (int)args.Phase, out nextPhase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
                Recycle();
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
                switch(phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(item);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            (this.obj3.Target as global::Windows.UI.Xaml.Controls.Grid).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::CLient_CS_UWP.Message) item, 1 << phase);
            }

            public void Recycle()
            {
            }

            // IChatPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::CLient_CS_UWP.Message)newDataRoot;
                    return true;
                }
                return false;
            }

            private delegate void InvokeFunctionDelegate(int phase);
            private global::System.Collections.Generic.Dictionary<string, InvokeFunctionDelegate> PendingFunctionBindings = new global::System.Collections.Generic.Dictionary<string, InvokeFunctionDelegate>();

            private void Invoke_M_HourMinute_757602046(int phase)
            {
                global::System.String result = this.dataRoot.HourMinute();
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // ChatPage.xaml line 42
                    if (!isobj9TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj9, result, null);
                    }
                }
            }

            private void CompleteUpdate(int phase)
            {
                var functions = this.PendingFunctionBindings;
                this.PendingFunctionBindings = new global::System.Collections.Generic.Dictionary<string, InvokeFunctionDelegate>();
                foreach (var function in functions.Values)
                {
                    function.Invoke(phase);
                }
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::CLient_CS_UWP.Message obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_MsgAlignment(obj.MsgAlignment, phase);
                        this.Update_PersonPictureVisibility(obj.PersonPictureVisibility, phase);
                        this.Update_BgColor(obj.BgColor, phase);
                        this.Update_TopHeight(obj.TopHeight, phase);
                        this.Update_Name(obj.Name, phase);
                        this.Update_OnlineBrush(obj.OnlineBrush, phase);
                        this.Update_Text(obj.Text, phase);
                        this.Update_M_HourMinute_757602046(phase);
                    }
                }
                this.CompleteUpdate(phase);
            }
            private void Update_MsgAlignment(global::Windows.UI.Xaml.HorizontalAlignment obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // ChatPage.xaml line 13
                    if (!isobj3HorizontalAlignmentDisabled)
                    {
                        if ((this.obj3.Target as global::Windows.UI.Xaml.Controls.Grid) != null)
                        {
                            XamlBindingSetters.Set_Windows_UI_Xaml_FrameworkElement_HorizontalAlignment((this.obj3.Target as global::Windows.UI.Xaml.Controls.Grid), obj);
                        }
                    }
                    // ChatPage.xaml line 30
                    if (!isobj7HorizontalAlignmentDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_FrameworkElement_HorizontalAlignment(this.obj7, obj);
                    }
                    // ChatPage.xaml line 39
                    if (!isobj8HorizontalAlignmentDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_FrameworkElement_HorizontalAlignment(this.obj8, obj);
                    }
                }
            }
            private void Update_PersonPictureVisibility(global::Windows.UI.Xaml.Visibility obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // ChatPage.xaml line 18
                    if (!isobj4VisibilityDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_UIElement_Visibility(this.obj4, obj);
                    }
                }
            }
            private void Update_BgColor(global::Windows.UI.Xaml.Media.SolidColorBrush obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // ChatPage.xaml line 23
                    if (!isobj5BackgroundDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Panel_Background(this.obj5, obj, null);
                    }
                }
            }
            private void Update_TopHeight(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // ChatPage.xaml line 26
                    if (!isobj6HeightDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_RowDefinition_Height(this.obj6, (global::Windows.UI.Xaml.GridLength) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.GridLength), obj));
                    }
                }
            }
            private void Update_Name(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // ChatPage.xaml line 30
                    if (!isobj7TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj7, obj, null);
                    }
                }
            }
            private void Update_OnlineBrush(global::Windows.UI.Xaml.Media.SolidColorBrush obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // ChatPage.xaml line 30
                    if (!isobj7ForegroundDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Foreground(this.obj7, obj, null);
                    }
                }
            }
            private void Update_Text(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // ChatPage.xaml line 39
                    if (!isobj8TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj8, obj, null);
                    }
                }
            }
            private void Update_M_HourMinute_757602046(int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    if (!isobj9TextDisabled)
                    {
                        this.PendingFunctionBindings["M_HourMinute_757602046"] = new InvokeFunctionDelegate(this.Invoke_M_HourMinute_757602046); 
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 10: // ChatPage.xaml line 60
                {
                    this.MessageBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.MessageBox).KeyDown += this.MessageBox_KeyDown;
                }
                break;
            case 11: // ChatPage.xaml line 72
                {
                    this.MessagesListView = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 12: // ChatPage.xaml line 64
                {
                    this.EmojiButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.EmojiButton).Click += this.Button_Click;
                }
                break;
            case 13: // ChatPage.xaml line 67
                {
                    this.SendButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.SendButton).Click += this.SendButton_Click;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 3: // ChatPage.xaml line 13
                {                    
                    global::Windows.UI.Xaml.Controls.Grid element3 = (global::Windows.UI.Xaml.Controls.Grid)target;
                    ChatPage_obj3_Bindings bindings = new ChatPage_obj3_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(element3.DataContext);
                    element3.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element3, bindings);
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element3, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

