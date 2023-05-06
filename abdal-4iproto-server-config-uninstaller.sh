#!/bin/bash
red='\033[0;31m'
green='\033[0;32m'
yellow='\033[0;33m'
plain='\033[0m'

# My name is Ebrahim Shafiei (EbraSha).
# I work as a programmer and cybersecurity professional.
# I have extensive experience in developing secure software and protecting against cyber threats.
# I am passionate about staying up-to-date with the latest security trends and technologies to provide the best possible solutions for my clients.
# Email: prof.shafiei@gmail.com
# Telegram: https://t.me/ProfShafiei
# Twitter: https://twitter.com/ProfShafiei

uninstalling() {
  rm -rf /usr/local/abdal-4iproto-server-config
  rm -f /usr/local/bin/Abdal4iProtoServerConfig
  rm -f /usr/local/abdal-4iproto-server-config.zip
  clear

  echo " "
  echo -e "${red}---------------------------------${plain}"
  echo -e "${green}Abdal 4iProto Server Config uninstalled successfully....${plain}"
  echo -e "${yellow}If there is a problem with the program, let us know: Prof.Shafiei@Gmail.com${plain}"
  echo -e "${red}---------------------------------${plain}"

}

# check root
[[ $EUID -ne 0 ]] && echo -e "${red}mistake：${plain} This script must be run with the root user！\n" && exit 1
if [[ ! -d "/usr/local/abdal-4iproto-server-config" ]]; then
  echo -e "${red}Error: Cannot remove abdal 4iproto server config, because it has not been set up on this server.${plain}"
else
  uninstalling
fi
