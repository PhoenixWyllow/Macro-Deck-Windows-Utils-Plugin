﻿using SuchByte.MacroDeck.ActionButton;
using SuchByte.MacroDeck.Plugins;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using WindowsInput.Native;

namespace SuchByte.WindowsUtils.Actions
{
    public class DecreaseVolumeAction : PluginAction
    {

        public override string Name => "Decrease volume";

        public override string DisplayName { get; set; } = "Decrease volume";

        public override string Description => "Decrease the volume of the current playback device";

        public override void Trigger(string clientId, ActionButton actionButton)
        {
            PluginInstance.Main.InputSimulator.Keyboard.KeyPress(VirtualKeyCode.VOLUME_DOWN);
        }
    }
}