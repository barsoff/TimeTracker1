﻿using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TimeTracker1
{
    public class HotKey : IMessageFilter
    {
        public event EventHandler HotKeyPressed;

        private int id = 0;

        #region Native win32 API

        private const int WM_HOTKEY = 0x0312;

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, KeyModifiers fsModifiers, Keys vk);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        [Flags()]
        public enum KeyModifiers
        {
            None = 0,
            Alt = 1,
            Control = 2,
            Shift = 4,
            Windows = 8
        }

        #endregion

        public event EventHandler KeyChanged;
        public event EventHandler KeyModifierChanged;
        private IntPtr handle;
        public IntPtr Handle
        {
            get { return handle; }
            set { handle = value; }
        }

        private Keys key;
        private KeyModifiers keyModifier;
        private bool isKeyRegisterd;

        public HotKey()
        {
            id = this.GetHashCode();
            Application.AddMessageFilter(this);
        }

        ~HotKey()
        {
            Application.RemoveMessageFilter(this);
            UnregisterHotKey(handle, id);
        }

        private void RegisterHotKey()
        {
            if (key == Keys.None)
                return;
            if (isKeyRegisterd)
                isKeyRegisterd = !(UnregisterHotKey(handle, id));
            isKeyRegisterd = RegisterHotKey(handle, id, keyModifier, key);
            if (!isKeyRegisterd)
                throw new ApplicationException("Hotkey allready in use");
        }

        [Bindable(true), Category("HotKey")]
        public Keys Key
        {
            get { return key; }
            set
            {
                if (key != value)
                {
                    key = value;
                    OnKeyChanged(new EventArgs());
                }
            }
        }

        [Bindable(true), Category("HotKey")]
        public KeyModifiers KeyModifier
        {
            get { return keyModifier; }

            set
            {
                if (keyModifier != value)
                {
                    keyModifier = value;
                    OnKeyModifierChanged(new EventArgs());
                }
            }
        }

        public bool PreFilterMessage(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_HOTKEY:
                    if ((int)(m.WParam) == id)
                    {
                        OnHotKeyPressed(new EventArgs());
                        return true;
                    }
                    break;
            }
            return false;
        }

        private void OnHotKeyPressed(EventArgs e)
        {
            if (HotKeyPressed != null)
                HotKeyPressed(this, e);
        }

        private void OnKeyChanged(EventArgs e)
        {
            RegisterHotKey();
            if (KeyChanged != null)
                KeyChanged(this, e);
        }

        private void OnKeyModifierChanged(EventArgs e)
        {
            RegisterHotKey();
            if (KeyModifierChanged != null)
                KeyModifierChanged(this, e);
        }
    }
}