using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace death_counter
{
	public partial class Form1 : Form
	{
		[DllImport("user32.dll")]
		private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

		[DllImport("user32.dll")]
		private static extern bool UnhookWindowsHookEx(IntPtr hhk);

		[DllImport("user32.dll")]
		private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

		[DllImport("kernel32.dll")]
		private static extern IntPtr GetModuleHandle(string lpModuleName);

		[DllImport("user32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

		private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
		private const uint SWP_NOSIZE = 0x0001;
		private const uint SWP_NOMOVE = 0x0002;
		private const uint SWP_SHOWWINDOW = 0x0040;

		private const int WH_KEYBOARD_LL = 13;
		private const int WM_KEYUP = 0x0101;

		private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);
		private LowLevelKeyboardProc _proc;
		private IntPtr _hookID = IntPtr.Zero;

		private System.Windows.Forms.Timer topmostTimer;

		public string prebrano;
		public string direkt;
		public int deaths;
		public string basepath = Directory.GetCurrentDirectory();

		public Form1()
		{
			InitializeComponent();
			this.Load += new EventHandler(Form1_Load);
			string parentPath = basepath;
			for (int i = 0; i < 3; i++)
			{
				parentPath = Directory.GetParent(parentPath).FullName;
			}
			direkt = Path.Combine(parentPath, "death_counter.txt");
			prebrano = File.ReadAllText(direkt);
			deaths = int.Parse(prebrano);
			number.Text = deaths.ToString();
			Console.WriteLine("current dir : " + basepath);
			Console.WriteLine("base path " + parentPath);

			this.TopMost = true;
			this.Opacity = 0.75;
			this.FormBorderStyle = FormBorderStyle.None;

			SetWindowPos(this.Handle, HWND_TOPMOST, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE | SWP_SHOWWINDOW);

			_proc = HookCallback;
			_hookID = SetHook(_proc);

			topmostTimer = new System.Windows.Forms.Timer();
			topmostTimer.Interval = 1000;
			topmostTimer.Tick += TopmostTimer_Tick;
			topmostTimer.Start();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// Determine the position to place the form in the top right corner
			int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
			int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;
			int formWidth = this.Width;
			int formHeight = this.Height;

			this.Location = new System.Drawing.Point(screenWidth - formWidth - 10, 10); // 10 pixels padding from right and top
		}

		private void TopmostTimer_Tick(object sender, EventArgs e)
		{
			SetWindowPos(this.Handle, HWND_TOPMOST, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE | SWP_SHOWWINDOW);
		}

		private IntPtr SetHook(LowLevelKeyboardProc proc)
		{
			using (Process curProcess = Process.GetCurrentProcess())
			using (ProcessModule curModule = curProcess.MainModule)
			{
				return SetWindowsHookEx(WH_KEYBOARD_LL, proc, GetModuleHandle(curModule.ModuleName), 0);
			}
		}

		private IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
		{
			if (nCode >= 0 && wParam == (IntPtr)WM_KEYUP)
			{
				int vkCode = Marshal.ReadInt32(lParam);
				if (vkCode == 0x20)
				{
					IncrementDeathCounter();
				}
			}
			return CallNextHookEx(_hookID, nCode, wParam, lParam);
		}

		protected override void OnFormClosing(FormClosingEventArgs e)
		{
			UnhookWindowsHookEx(_hookID);
			topmostTimer.Stop();
			base.OnFormClosing(e);
		}

		private void buttondeath_Click(object sender, EventArgs e)
		{
			IncrementDeathCounter();
		}

		private void IncrementDeathCounter()
		{
			deaths++;
			number.Text = deaths.ToString();
			File.WriteAllText(direkt, number.Text);
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
