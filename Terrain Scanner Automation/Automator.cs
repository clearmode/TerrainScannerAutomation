using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;
using System.Runtime.InteropServices;
using WindowsInput;
using WindowsInput.Native;

namespace Terrain_Scanner_Automation
{
    public class Automator
    {

        private int _minecraftProcessID;
        public int MinecraftProcessID
        {
            get
            {
                return _minecraftProcessID;
            }

            set
            {
                _minecraftProcessID = value;
                _minecraftProcess = Process.GetProcessById(_minecraftProcessID);
            }
        }

        Process _minecraftProcess;
        Thread _run;
        InputSimulator _input;
        

        public Automator()
        {
            _input = new InputSimulator();
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
                MoveRightOneBlock();
                Thread.Sleep(500);
                MoveLeftOneBlock();
            }
        }
        
        private void MoveRightOneBlock()
        {
            _input.Keyboard.KeyDown(VirtualKeyCode.VK_D);
            Thread.Sleep(100);
            _input.Keyboard.KeyUp(VirtualKeyCode.VK_D);
        }
        
        private void MoveLeftOneBlock()
        {
            _input.Keyboard.KeyDown(VirtualKeyCode.VK_A);
            Thread.Sleep(100);
            _input.Keyboard.KeyUp(VirtualKeyCode.VK_A);
        }

        private void TypeCoordinates()
        {
            
        }
        
        
    }
}
