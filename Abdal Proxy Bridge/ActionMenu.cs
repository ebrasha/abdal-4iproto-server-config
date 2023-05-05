using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abdal_Proxy_Bridge
{
    internal class ActionMenu
    {
        public static void ActionMenuRunner()
        {
            var user_entry = Console.ReadLine();

            //5. Users list
            if (user_entry == "5")
            {
                CommandHndl.users_list_reader(GlobVar.udb_location);
            }

            //6. Change User password
            if (user_entry == "6")
            {
                MessageManagements.WarningMessageCw("Please Enter The Username: ");
                var userName = Console.ReadLine();
                MessageManagements.WarningMessageCw("Please Enter The New Password: ");
                var userPass = Console.ReadLine();
                string sh_config_path = @"ssh_config.sh";
                CommandHndl.ConfigDelete(sh_config_path);
                var command =
                    $"echo -e \"{userPass}\\n{userPass}\\n\" |   passwd   {userName}     --quiet  ";
                CommandHndl.ConfigFileWriter(sh_config_path, command);
                CommandHndl.ExecuteBashFile(sh_config_path);

                CommandHndl.ConfigDelete(sh_config_path);
                CommandHndl.ExecuteCommand("clear");
                AbdalBanners.StartBanner02();

                var user_info = $"""
                 
                ------- password changed Information -------
                UserName = {userName}
                Password = {userPass} 
                ------------------------------
                
                """ + Environment.NewLine;
                Console.WriteLine(user_info);
                MessageManagements.SuccessMessage("User password changed successfully!!");
            }

            // 3. Create User
            if (user_entry == "3")
            {
                MessageManagements.SuccessMessageCW("Please Enter The Username: ");
                var userName = Console.ReadLine();

                if (File.Exists(GlobVar.udb_location + userName))
                {
                    MessageManagements.DangerMessage("This Username Exists! try with another username");
                }
                else
                {
                    MessageManagements.SuccessMessageCW("Please Enter The Password: ");
                    var userPass = Console.ReadLine();
                    string sh_config_path = @"ssh_config.sh";
                    CommandHndl.ConfigDelete(sh_config_path);
                    var command =
                        $"echo -e \"{userPass}\\n{userPass}\\n\" |   adduser {userName}  --no-create-home  --quiet   --gecos GECOS";
                    CommandHndl.ConfigFileWriter(sh_config_path, command);
                    CommandHndl.ExecuteBashFile(sh_config_path);

                    CommandHndl.ConfigDelete(sh_config_path);
                    CommandHndl.ExecuteCommand("clear");
                    AbdalBanners.StartBanner02();

                    var user_info = $"""
                 
                ------- NewUser Information -------
                UserName = {userName}
                Password = {userPass} 
                ------------------------------
                
                """ + Environment.NewLine;
                    Console.WriteLine(user_info);
                    MessageManagements.SuccessMessage("Create NewUser is done!");

                    CommandHndl.UserAcountFileMaker(GlobVar.udb_location, userName, userPass);
                }
            }

            //"4. Delete User by username"
            if (user_entry == "4")
            {
                MessageManagements.SuccessMessageCW("Please Enter The Username: ");
                var userName = Console.ReadLine();

                string sh_config_path = @"ssh_config.sh";
                CommandHndl.ConfigDelete(sh_config_path);
                var command = $"userdel -r {userName}";
                CommandHndl.ConfigFileWriter(sh_config_path, command);
                CommandHndl.ExecuteBashFile(sh_config_path);
                CommandHndl.ExecuteCommand("clear");
                AbdalBanners.StartBanner02();
                AcMng.delete_file_user(GlobVar.udb_location, userName);

                CommandHndl.ConfigDelete(sh_config_path);
            }


            if (user_entry == "1")
            {
                CommandHndl.ExecuteCommand("clear");
                CommandHndl.ExecuteCommand("apt clean all");
                CommandHndl.ExecuteCommand("apt update");
                CommandHndl.ExecuteCommand("apt install nano -y");
                CommandHndl.ExecuteCommand("apt install dropbear -y");
                CommandHndl.ExecuteCommand("clear");
                AbdalBanners.StartBanner02();
                MessageManagements.SuccessMessage("Install prerequisites is done!");
            }


            if (user_entry == "2")
            {
                string sh_config_path = @"ssh_config.sh";
                // Config SSH Server
                CommandHndl.ConfigFileWriter(sh_config_path,
                    "sed -i \"s/^#AllowAgentForwarding .*\\$/AllowAgentForwarding yes/\" /etc/ssh/sshd_config;");
                CommandHndl.ConfigFileWriter(sh_config_path,
                    "sed -i \"s/^#AllowTcpForwarding .*\\$/AllowTcpForwarding yes/\" /etc/ssh/sshd_config;");
                CommandHndl.ConfigFileWriter(sh_config_path,
                    "sed -i \"s/^#GatewayPorts .*\\$/GatewayPorts yes/\" /etc/ssh/sshd_config;");
                CommandHndl.ConfigFileWriter(sh_config_path,
                    "sed -i \"s/^#X11Forwarding .*\\$/X11Forwarding yes/\" /etc/ssh/sshd_config;");
                CommandHndl.ConfigFileWriter(sh_config_path,
                    "sed -i \"s/^#MaxStartups .*\\$/MaxStartups 1000:30:10000/\" /etc/ssh/sshd_config;");
                CommandHndl.ConfigFileWriter(sh_config_path,
                    "sed -i \"s/^#TCPKeepAlive .*\\$/TCPKeepAlive yes/\" /etc/ssh/sshd_config;");
                CommandHndl.ConfigFileWriter(sh_config_path,
                    "sed -i \"s/^AllowStreamLocalForwarding .*\\$/AllowStreamLocalForwarding yes/\" /etc/ssh/sshd_config;");
                CommandHndl.ConfigFileWriter(sh_config_path,
                    "sed -i \"s/^#PrintMotd .*\\$/PrintMotd no/\" /etc/ssh/sshd_config;");
                CommandHndl.ConfigFileWriter(sh_config_path,
                    "sed -i \"s/^UseDNS .*\\$/UseDNS no/\" /etc/ssh/sshd_config;");
                CommandHndl.ConfigFileWriter(sh_config_path,
                    "sed -i \"s/^#Compression .*\\$/Compression yes/\" /etc/ssh/sshd_config;");
                CommandHndl.ConfigFileWriter(sh_config_path,
                    "sed -i \"s/^#ClientAliveInterval .*\\$/ClientAliveInterval 360000/\" /etc/ssh/sshd_config;");
                CommandHndl.ConfigFileWriter(sh_config_path,
                    "sed -i \"s/^#ClientAliveCountMax .*\\$/ClientAliveCountMax 3000/\" /etc/ssh/sshd_config;");
                CommandHndl.ConfigFileWriter(sh_config_path,
                    "sed -i \"s/^#PermitTunnel .*\\$/PermitTunnel yes/\" /etc/ssh/sshd_config;");
                CommandHndl.ConfigFileWriter(sh_config_path,
                    "sed -i \"s/^#MaxSessions .*\\$/MaxSessions 1000/\" /etc/ssh/sshd_config;");
                CommandHndl.ConfigFileWriter(sh_config_path,
                    "sed -i \"s/^#AddressFamily .*\\$/AddressFamily inet/\" /etc/ssh/sshd_config;");
                CommandHndl.ConfigFileWriter(sh_config_path, "systemctl restart ssh &&  systemctl restart sshd");
                // Config DropBear

                CommandHndl.ConfigFileWriter(sh_config_path,
                    "sed -i \"s/^NO_START.*\\$/NO_START=0/\" /etc/default/dropbear;");
                CommandHndl.ConfigFileWriter(sh_config_path,
                    "sed -i \"s/^DROPBEAR_PORT.*\\$/DROPBEAR_PORT=49600/\" /etc/default/dropbear;");
                CommandHndl.ConfigFileWriter(sh_config_path,
                    "sed -i \"s/^DROPBEAR_EXTRA_ARGS.*\\$/DROPBEAR_EXTRA_ARGS=\\\"-p 49601  -p 49602  -p 49603 -p 49706\\\"/\" /etc/default/dropbear;");
                CommandHndl.ConfigFileWriter(sh_config_path,
                    "systemctl restart dropbear && systemctl enable dropbear && systemctl restart dropbear ");
                // sysctl 
                CommandHndl.ConfigFileWriter(sh_config_path,
                    "echo  \"net.ipv4.ip_forward = 1\"   >>  /etc/sysctl.conf");
                CommandHndl.ConfigFileWriter(sh_config_path,
                    "echo  \"net.ipv4.conf.all.forwarding = 1\"   >>  /etc/sysctl.conf");
                CommandHndl.ConfigFileWriter(sh_config_path,
                    "echo  \"net.ipv4.conf.default.forwarding = 1\"   >>  /etc/sysctl.conf");
                CommandHndl.ConfigFileWriter(sh_config_path,
                    "echo  \"net.ipv4.conf.all.accept_source_route = 0\"   >>  /etc/sysctl.conf");
                CommandHndl.ConfigFileWriter(sh_config_path,
                    "echo  \"net.ipv4.conf.default.accept_source_route = 0\"   >>  /etc/sysctl.conf");
                CommandHndl.ConfigFileWriter(sh_config_path,
                    "echo  \"net.ipv4.conf.all.send_redirects = 0\"   >>  /etc/sysctl.conf");
                CommandHndl.ConfigFileWriter(sh_config_path,
                    "echo  \"net.ipv4.conf.default.send_redirects = 0\"   >>  /etc/sysctl.conf");
                CommandHndl.ConfigFileWriter(sh_config_path,
                    "echo  \"net.ipv4.conf.all.accept_redirects = 0\"   >>  /etc/sysctl.conf");
                CommandHndl.ConfigFileWriter(sh_config_path,
                    "echo  \"net.ipv4.conf.default.accept_redirects = 0\"   >>  /etc/sysctl.conf");
                CommandHndl.ConfigFileWriter(sh_config_path,
                    "echo  \"net.ipv4.conf.all.secure_redirects = 0\"   >>  /etc/sysctl.conf");
                CommandHndl.ConfigFileWriter(sh_config_path,
                    "echo  \"net.ipv4.conf.default.secure_redirects = 0\"   >>  /etc/sysctl.conf");
                CommandHndl.ConfigFileWriter(sh_config_path, "echo  \"net.ipv4.tcp_sack = 0\"   >>  /etc/sysctl.conf");
                CommandHndl.ConfigFileWriter(sh_config_path, "echo  \"net.ipv4.tcp_dsack = 0\"   >>  /etc/sysctl.conf");
                CommandHndl.ConfigFileWriter(sh_config_path, "echo  \"net.ipv4.tcp_fack = 0\"   >>  /etc/sysctl.conf");
                CommandHndl.ConfigFileWriter(sh_config_path,
                    "echo  \"net.ipv4.tcp_syncookies = 1\"   >>  /etc/sysctl.conf");
                CommandHndl.ConfigFileWriter(sh_config_path,
                    "echo  \"net.ipv4.tcp_syn_retries = 2\"   >>  /etc/sysctl.conf");
                CommandHndl.ConfigFileWriter(sh_config_path,
                    "echo  \"net.ipv4.tcp_synack_retries = 2\"   >>  /etc/sysctl.conf");

                CommandHndl.ConfigFileWriter(sh_config_path, "sysctl -p");


                CommandHndl.ExecuteBashFile(sh_config_path);

                CommandHndl.ConfigDelete(sh_config_path);
                CommandHndl.ExecuteCommand("clear");
                AbdalBanners.StartBanner02();
                MessageManagements.SuccessMessage("Main server configuration is done!");
            }

            if (user_entry == "q")
            {
                Environment.Exit(0);
            }
        }
    }
}