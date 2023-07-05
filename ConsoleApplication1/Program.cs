using System;
using System.Diagnostics;

namespace ConsoleApplication1
{
	// Token: 0x02000002 RID: 2
	internal class Program
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002058 File Offset: 0x00000258
		private static void Main(string[] args)
		{
			Process[] processes = Process.GetProcesses();
			int num = 0;
			foreach (Process process in processes)
			{
				if (process.ProcessName == "servisatk")
				{
					process.Kill();
					num = 1;
					break;
				}
				num = 0;
			}
			if (num == 1)
			{
				Environment.Exit(0);
				return;
			}
			Environment.Exit(0);
		}
	}
}
