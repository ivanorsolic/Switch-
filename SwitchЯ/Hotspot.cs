using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotspotTest
{
    public class Hotspot
    {
        public static void GoHotspot(bool status)
        {

            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";

            if(process != null)
            {
                if(status)
                {
                    startInfo.Arguments = "/C netsh wlan set hostednetwork mode=allow ssid=SwitchR key=SwitchRHotspot!";
                    process.StartInfo = startInfo;
                    process.Start();
                    startInfo.Arguments = "/C netsh wlan start hosted network";
                    process.StartInfo = startInfo;
                    process.Start();
                }
                else
                {
                    startInfo.Arguments = "/C netsh wlan stop hostednetwork";
                    process.StartInfo = startInfo;
                    process.Start();
                }
            }
        }
        public static string ARP()
        {
            Process process = new Process();

            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "/C arp -a -N 192.168.137.1";
            process.Start();

            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            string pattern = @"\b192{ 1}\.168{ 1}\.137{ 1}\.[^255]{1}\b";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(output);
            return match.Value;
        }
        
        public static string SSH(string ip, string command)
        {
            using (var client = new SshClient(ip, "pi", "raspberry"))
            {
                client.Connect();
                SshCommand SSHcommand = client.CreateCommand(command);
                string result = SSHcommand.Execute();
                client.Disconnect();
                return result;
            }
        }
    }
}
