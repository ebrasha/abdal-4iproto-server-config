#!/bin/bash
red='\033[0;31m'
green='\033[0;32m'
yellow='\033[0;33m'
plain='\033[0m'

installer() {
  apt update
  apt install wget curl tar zip unzip -y
  cd /usr/local/
  url_zip_file="https://raw.githubusercontent.com/ebrasha/abdal-4iproto-server-config/main/abdal-4iproto-server-config-debian.11-x64.zip"
  wget -N --no-check-certificate -O /usr/local/abdal-4iproto-server-config.zip ${url_zip_file}
  unzip /usr/local/abdal-4iproto-server-config.zip
  cd /usr/local/abdal-4iproto-server-config
  chmod +x Abdal4iProtoServerConfig
  rm -f /usr/local/bin/Abdal4iProtoServerConfig
  ln -s /usr/local/abdal-4iproto-server-config/Abdal4iProtoServerConfig /usr/local/bin
  mkdir /usr/local/abdal-4iproto-server-config-db/
  echo Abdal 4iProto Server Config installed successfully....
  rm -f /usr/local/abdal-4iproto-server-config.zip

  echo " "
  echo -e "${red}---------------------------------${plain}"
  echo -e "${green}Abdal 4iProto Server Config installed successfully....${plain}"
  echo -e "${green}If need more options, let us know: Prof.Shafiei@Gmail.com${plain}"
  echo -e "${red}---------------------------------${plain}"

}

# check root
[[ $EUID -ne 0 ]] && echo -e "${red}mistake：${plain} This script must be run with the root user！\n" && exit 1

installer
