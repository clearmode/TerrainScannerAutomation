﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;
using System.Runtime.InteropServices;

namespace Terrain_Scanner_Automation
{
    public class Automator
    {
        const UInt32 WM_KEYDOWN = 0x0100;
        const UInt32 WM_KEYUP = 0x0101;
        const int VK_W = 0x57;
        const int VK_A = 0x41;
        const int VK_D = 0x44;
        const int VK_0 = 0x30;
        const int VK_1 = 0x31;
        const int VK_2 = 0x32;
        const int VK_3 = 0x33;
        const int VK_4 = 0x34;
        const int VK_5 = 0x35;
        const int VK_6 = 0x36;
        const int VK_7 = 0x37;
        const int VK_8 = 0x38;
        const int VK_9 = 0x39;

        [DllImport("user32.dll")]
        static extern bool PostMessage(IntPtr hWnd, UInt32 Msg, int wParam, int lParam);

        public int MinecraftProcessID { get; set; }

        Process _minecraftProcess;
        Thread _run;

        public Automator()
        {
            _minecraftProcess = Process.GetProcessById(MinecraftProcessID);
        }

        private bool _running;
        public bool Running
        {
            private get => _running;
            set
            {
                if (!_running && value)
                {
                    _running = value;
                    _run = new Thread(Run);
                    _run.Start();
                }
                else if(_running && !value)
                {
                    _running = value;
                }
            }
        }

        private void Run()
        {
            while (_running)
            {
                Console.WriteLine("loop");
                MoveRightOneBlock();
                Thread.Sleep(500);
                MoveLeftOneBlock();
            }
        }
        
        private void MoveRightOneBlock()
        {
            Console.WriteLine("Moving right");
            Console.WriteLine("postmessage " + PostMessage(_minecraftProcess.MainWindowHandle, WM_KEYDOWN, VK_D, 0));
            Thread.Sleep(2000);
            PostMessage(_minecraftProcess.MainWindowHandle, WM_KEYUP, VK_D, 0);
        }
        
        private void MoveLeftOneBlock()
        {
            Console.WriteLine("Moving left");
            PostMessage(_minecraftProcess.MainWindowHandle, WM_KEYDOWN, VK_A, 0);
            Thread.Sleep(500);
            PostMessage(_minecraftProcess.MainWindowHandle, WM_KEYUP, VK_A, 0);
        }

        private void TypeCoordinates()
        {
            
            PostMessage(_minecraftProcess.MainWindowHandle, WM_KEYDOWN, VK_D, 0);
            Thread.Sleep(500);
            PostMessage(_minecraftProcess.MainWindowHandle, WM_KEYUP, VK_D, 0);
        }
        
        
    }
}
