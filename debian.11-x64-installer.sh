#!/bin/bash
red='\033[0;31m'
green='\033[0;32m'
yellow='\033[0;33m'
plain='\033[0m'

installer() {
  ## variables
  os_command=""
  url_zip_file=""

  echo -e "${green}Please select your operating system version:${plain}"
  echo -e "${yellow}1. debian.11-x64${plain}"
  echo -e "${yellow}2. debian.10-x64${plain}"
  echo -e "${yellow}3. ubuntu.22.04-x64${plain}"
  echo -e "${yellow}4. ubuntu.20.04-x64${plain}"
  echo -e "${yellow}5. ubuntu.18.04-x64${plain}"
  echo -e "${yellow}6. centos.7-x64${plain}"
  echo -e "${yellow}7. rhel.7-x64${plain}"
  echo -e "${yellow}8. rhel.8-x64${plain}"
  echo -e "${yellow}9. fedora.37-x64${plain}"

  read os_selector
  #1. debian.11-x64
  if [ $os_selector -eq "1" ]; then
    os_command="apt"
    url_zip_file="https://github.com/ebrasha/abdal-4iproto-server-config/releases/download/v4/abdal-4iproto-server-config-debian.11-x64.zip"

    echo $url_zip_file
    exit  1
    $os_command update
    $os_command install wget curl tar zip unzip -y
    cd /usr/local/
    wget -N --no-check-certificate -O /usr/local/abdal-4iproto-server-config.zip ${url_zip_file}
    unzip /usr/local/abdal-4iproto-server-config.zip
    cd /usr/local/abdal-4iproto-server-config
    chmod +x Abdal4iProtoServerConfig
    rm -f /usr/local/bin/Abdal4iProtoServerConfig
    ln -s /usr/local/abdal-4iproto-server-config/Abdal4iProtoServerConfig /usr/local/bin
    mkdir /usr/local/abdal-4iproto-server-config-db/
    rm -f /usr/local/abdal-4iproto-server-config.zip

    echo " "
    echo -e "${red}---------------------------------${plain}"
    echo -e "${green}Abdal 4iProto Server Config installed successfully....${plain}"
    echo -e "${green}If need more options, let us know: Prof.Shafiei@Gmail.com${plain}"
    echo -e "${red}---------------------------------${plain}"

  fi

  if [ $os_selector -eq "2" ]; then
    os_command="apt"
    url_zip_file="https://github.com/ebrasha/abdal-4iproto-server-config/releases/download/v4/abdal-4iproto-server-config-debian.10-x64.zip"
  fi

}

# check root
[[ $EUID -ne 0 ]] && echo -e "${red}mistake：${plain} This script must be run with the root user！\n" && exit 1

installer
