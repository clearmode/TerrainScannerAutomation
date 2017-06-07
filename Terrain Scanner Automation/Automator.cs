using System;
using System.Threading;
using WindowsInput;
using WindowsInput.Native;

namespace Terrain_Scanner_Automation
{
    public class Automator
    {
        
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
            ChunkList.Chunk currentChunk;

            while (_running && !(currentChunk = ChunkList.GetAndRemoveFirstChunk()).Equals(null))
            {
                UseScannerQueue(currentChunk.X, currentChunk.Z);
                MoveRightOneBlock();
                UseTerrainScanner();
                MoveLeftOneBlock();

                Thread.Sleep(150000);
            }

            _running = false;
        }

        private void MoveRightOneBlock()
        {
            _input.Keyboard.KeyDown(VirtualKeyCode.VK_D);
            Thread.Sleep(250);
            _input.Keyboard.KeyUp(VirtualKeyCode.VK_D);
        }
        
        private void MoveLeftOneBlock()
        {
            _input.Keyboard.KeyDown(VirtualKeyCode.VK_A);
            Thread.Sleep(250);
            _input.Keyboard.KeyUp(VirtualKeyCode.VK_A);
        }

        private void UseScannerQueue(int x, int z)
        {
            _input.Mouse.RightButtonClick();
            Thread.Sleep(100);
            _input.Mouse.MoveMouseBy(110, -120);
            Thread.Sleep(100);
            _input.Mouse.LeftButtonClick();
            Thread.Sleep(100);
            _input.Mouse.MoveMouseBy(-110, 170);
            Thread.Sleep(100);
            _input.Mouse.LeftButtonClick();
            Thread.Sleep(100);
            _input.Keyboard.TextEntry(x + "," + z);
            Thread.Sleep(100);
            _input.Mouse.MoveMouseBy(0, -50);
            Thread.Sleep(100);
            _input.Mouse.LeftButtonClick();
            Thread.Sleep(100);
            _input.Mouse.MoveMouseBy(-110, -120);
            Thread.Sleep(100);
            _input.Mouse.LeftButtonClick();
            Thread.Sleep(100);
            _input.Keyboard.KeyPress(VirtualKeyCode.ESCAPE);
            Thread.Sleep(100);
        }

        private void UseTerrainScanner()
        {
            _input.Mouse.RightButtonClick();
            Thread.Sleep(100);
            _input.Mouse.MoveMouseBy(0, 80);
            Thread.Sleep(100);
            _input.Mouse.LeftButtonClick();
            Thread.Sleep(100);
            _input.Keyboard.KeyPress(VirtualKeyCode.ESCAPE);
            Thread.Sleep(100);
        }
        
    }
}
