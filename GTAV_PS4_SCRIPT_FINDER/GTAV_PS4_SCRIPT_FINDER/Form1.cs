using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libdebug;

namespace GTAV_PS4_SCRIPT_FINDER
{
    public partial class Form1 : Form
    {
        private PS4DBG ps4;
        ulong v_scriptAddr;
        ulong v_scriptsPointer = 0x20AAA99D0;//EUR-1.38
        public int currentPID;
        public bool isReady;
        public Form1()
        {
            InitializeComponent();
        }
        enum OSCHeader
        {
            pageBase = 0x0,
            pageMapPointer = 0x8,
            CodeBlocksBasePointer = 0x10,
            GlobalsSignature = 0x18,
            CodeSize = 0x1c,
            ParameterCount = 0x20,
            StaticCount = 0x24,
            GlobalCount = 0x28,
            NativesCount = 0x2C,
            StaticsPointer = 0x30,
            GlobalsPointer = 0x38,
            NativesPointer = 0x40,
            Null1 = 0x48,
            Null2 = 0x50,
            ScriptNameHash = 0x58,
            UnkUsually1 = 0x5C,
            ScriptNamePointer = 0x60,
            StringBlocksBasePointer = 0x68,
        };

        private static uint CreateHash(string Native)
        {
            uint num = 0u;
            byte[] bytes = Encoding.UTF8.GetBytes(Native);
            for (int i = 0; i < bytes.Length; i++)
            {
                num += (uint)bytes[i];
                num += num << 10;
                num ^= num >> 6;
            }
            num += num << 3;
            num ^= num >> 11;
            return num + (num << 15);
        }
        private void dumpScript_Click(object sender, EventArgs e)
        {
            //use the same script checker then get the
            uint curScriptHash = CreateHash(scr_name.Text);
            for (int i = 0; i <= 990; i++)
            {
                uint scriptHash = BitConverter.ToUInt32(this.ps4.ReadMemory(currentPID, v_scriptsPointer + 0xC + (0x10 * Convert.ToUInt64(i)), 8), 0);
                if (curScriptHash == scriptHash)
                {
                    v_scriptAddr = BitConverter.ToUInt64(this.ps4.ReadMemory(currentPID, v_scriptsPointer + (0x10 * Convert.ToUInt64(i)), 8), 0);
                    if (v_scriptAddr == 0)
                    {
                        MessageBox.Show("The script entered is currently inactive, so it does not have an address, try with another script.");
                        break;
                    }
                    else
                    {
                       // ulong v_endOfScript = BitConverter.ToUInt64(this.ps4.ReadMemory(currentPID, v_scriptAddr + (ulong)(OSCHeader.StringBlocksBasePointer), 8), 0);// just dump from start to end, I'm lazy to do it (:
                        break;
                    }
                }
            }
        }

        private void scriptCheck_Click(object sender, EventArgs e)
        {
            uint curScriptHash = CreateHash(scr_name.Text);
            for (int i = 0; i <= 990; i++)
            {
                uint scriptHash = BitConverter.ToUInt32(this.ps4.ReadMemory(currentPID, v_scriptsPointer + 0xC + (0x10 * Convert.ToUInt64(i)), 8), 0);
                if (curScriptHash == scriptHash)
                {
                    v_scriptAddr = BitConverter.ToUInt64(this.ps4.ReadMemory(currentPID, v_scriptsPointer + (0x10 * Convert.ToUInt64(i)), 8), 0);
                    if (v_scriptAddr == 0)
                    {
                        string _null = "N/A";
                        _r_codesize.Text = _null;
                        _r_nativescount.Text = _null;
                        _r_globalscount.Text = _null;
                        _r_staticcount.Text = _null;
                        _r_scrAddr.Text = _null;
                        MessageBox.Show("The script entered is currently inactive, so it does not have an address, try with another script.");
                        break;
                    }
                    else
                    {
                        uint v_codesize = BitConverter.ToUInt32(this.ps4.ReadMemory(currentPID, v_scriptAddr + (ulong)(OSCHeader.CodeSize), 4), 0);
                        uint v_nativescount = BitConverter.ToUInt32(this.ps4.ReadMemory(currentPID, v_scriptAddr + (ulong)(OSCHeader.NativesCount), 4), 0);
                        uint v_globalscount= BitConverter.ToUInt32(this.ps4.ReadMemory(currentPID, v_scriptAddr + (ulong)(OSCHeader.GlobalCount), 4), 0);
                        uint v_staticcount= BitConverter.ToUInt32(this.ps4.ReadMemory(currentPID, v_scriptAddr + (ulong)(OSCHeader.StaticCount), 4), 0);
                        _r_codesize.Text = v_codesize.ToString();
                        _r_nativescount.Text = v_nativescount.ToString();
                        _r_globalscount.Text = v_globalscount.ToString();
                        _r_staticcount.Text = v_staticcount.ToString();
                        _r_scrAddr.Text = " 0x" + v_scriptAddr.ToString("X");
                        MessageBox.Show("static script pointer: 0x" + (v_scriptsPointer + (0x10 * Convert.ToUInt64(i))).ToString("X") + ", " + "the address of script: " + scr_name.Text + " >" + " 0x" + v_scriptAddr.ToString("X"));
                        var v0 = "0x" + v_scriptsPointer.ToString("X");
                        Clipboard.SetText(v0);
                        break;
                    }
                }
            }
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            isReady = false;
            DialogResult dialogResult = DialogResult.Yes;
            if (this.ps4 != null && this.ps4.IsConnected)
                dialogResult = MessageBox.Show("You are already connected...\nWould you like to reconnect?",
                    "GTA V Script Finder v1.38", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (dialogResult != DialogResult.Yes)
                return;
            this.ps4 = new PS4DBG(this.textIp.Text);
            this.ps4.Connect();
            if (this.ps4 != null && this.ps4.IsConnected)
            {
                Process[] processes = this.ps4.GetProcessList().processes;
                for (int i = 0; i < processes.Length; i++)
                {
                    Process process = processes[i];
                    if (process.name == "eboot.bin")
                    {
                        currentPID = process.pid;
                        isReady = true;
                        toolStripStatusLabel2.Text = "Connected";
                        toolStripStatusLabel2.ForeColor = Color.Green;
                        this.ps4.Notify(222, "GTA V Script Finder Connectedr v1.38.");
                    }
                }
            }
        }
    }
}
