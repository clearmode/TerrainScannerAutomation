using System;
using System.Threading;
using WindowsInput;
using WindowsInput.Native;

namespace Terrain_Scanner_Automation
{
    public class Automator
    {
        
        private Thread _run;
        private InputSimulator _input;
        

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
            Wait();
            _input.Mouse.MoveMouseBy(110, -120);
            Wait();
            _input.Mouse.LeftButtonClick();
            Wait();
            _input.Mouse.MoveMouseBy(-110, 170);
            Wait();
            _input.Mouse.LeftButtonClick();
            Wait();
            _input.Keyboard.TextEntry(x + "," + z);
            Wait();
            _input.Mouse.MoveMouseBy(0, -50);
            Wait();
            _input.Mouse.LeftButtonClick();
            Wait();
            _input.Mouse.MoveMouseBy(-110, -120);
            Wait();
            _input.Mouse.LeftButtonClick();
            Wait();
            _input.Keyboard.KeyPress(VirtualKeyCode.ESCAPE);
            Wait();
        }

        private void UseTerrainScanner()
        {
            _input.Mouse.RightButtonClick();
            Wait();
            _input.Mouse.MoveMouseBy(0, 90);
            Wait();
            _input.Mouse.LeftButtonClick();
            Wait();
            _input.Keyboard.KeyPress(VirtualKeyCode.ESCAPE);
            Wait();
        }

        private void Wait()
        {
            Thread.Sleep(150);
        }
        
    }
}
