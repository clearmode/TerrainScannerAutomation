using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Terrain_Scanner_Automation
{
    public partial class AutomationDisplay : Form
    {
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, Keys key);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        const int START_HOTKEY_ID = 1;
        const int STOP_HOTKEY_ID = 2;
        Automator _auto;
        ChunkList.Chunk currentChunk;

        public AutomationDisplay()
        {
            InitializeComponent();

            if (!RegisterHotKey(this.Handle, START_HOTKEY_ID, 0, Keys.NumPad7))
            {
                throw new Win32Exception(Marshal.GetLastWin32Error());
            }

            if (!RegisterHotKey(this.Handle, STOP_HOTKEY_ID, 0, Keys.NumPad8))
            {
                throw new Win32Exception(Marshal.GetLastWin32Error());
            }

            _auto = new Automator();

            btnNorth.Enabled = false;
            btnEast.Enabled = false;
            btnSouth.Enabled = false;
            btnWest.Enabled = false;

            dgvChunkQueue.RowHeadersVisible = false;
            dgvChunkQueue.AutoGenerateColumns = false;
            dgvChunkQueue.DataSource = ChunkList.Chunks;
            dgvChunkQueue.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "X",
                Width = 50,
                DataPropertyName = "X"
            });

            dgvChunkQueue.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Z",
                Width = 50,
                DataPropertyName = "Z"
            });

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == START_HOTKEY_ID)
            {
                Console.WriteLine("Start");
                _auto.Running = true;
            }
            else if (m.Msg == 0x0312 && m.WParam.ToInt32() == STOP_HOTKEY_ID)
            {
                Console.WriteLine("Stop");
                _auto.Running = false;
            }

            base.WndProc(ref m);
        }

        private void btnNorth_Click(object sender, EventArgs e)
        {
            currentChunk = ChunkList.AddChunk(currentChunk.X, currentChunk.Z - 16);
            UpdateCurrentChunkLabel();
        }

        private void btnEast_Click(object sender, EventArgs e)
        {
            currentChunk = ChunkList.AddChunk(currentChunk.X + 16, currentChunk.Z);
            UpdateCurrentChunkLabel();
        }

        private void btnSouth_Click(object sender, EventArgs e)
        {
            currentChunk = ChunkList.AddChunk(currentChunk.X, currentChunk.Z + 16);
            UpdateCurrentChunkLabel();
        }

        private void btnWest_Click(object sender, EventArgs e)
        {
            currentChunk = ChunkList.AddChunk(currentChunk.X - 16, currentChunk.Z);
            UpdateCurrentChunkLabel();
        }

        private void btnSetStartChunk_Click(object sender, EventArgs e)
        {
            int commaPos = tbStartChunk.Text.IndexOf(',');
            int x = Int32.Parse(tbStartChunk.Text.Substring(0, commaPos));
            int z = Int32.Parse(tbStartChunk.Text.Substring(commaPos+1));
            currentChunk = ChunkList.AddChunk(x, z);
            UpdateCurrentChunkLabel();
            tbStartChunk.Enabled = false;
            btnSetStartChunk.Enabled = false;
            btnNorth.Enabled = true;
            btnEast.Enabled = true;
            btnSouth.Enabled = true;
            btnWest.Enabled = true;
        }

        private void UpdateCurrentChunkLabel()
        {
            lblChunkX.Text = currentChunk.X + "";
            lblChunkZ.Text = currentChunk.Z + "";
        }

        private void btnRemoveChunk_Click(object sender, EventArgs e)
        {
            ChunkList.Chunks.RemoveAt(dgvChunkQueue.CurrentCell.RowIndex);
        }
    }
}
