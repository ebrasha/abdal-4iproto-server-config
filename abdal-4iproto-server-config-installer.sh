#!/bin/bash
# My name is Ebrahim Shafiei (EbraSha).
# I work as a programmer and cybersecurity professional.
# I have extensive experience in developing secure software and protecting against cyber threats.
# I am passionate about staying up-to-date with the latest security trends and technologies to provide the best possible solutions for my clients.
# Email: prof.shafiei@gmail.com
# Telegram: https://t.me/ProfShafiei
# Twitter: https://twitter.com/ProfShafiei

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
  echo -e "${yellow}2. debian.11-arm64${plain}"
  echo -e "${yellow}3. debian.10-x64${plain}"
  echo -e "${yellow}4. ubuntu.22.04-arm64${plain}"
  echo -e "${yellow}5. ubuntu.22.04-x64${plain}"
  echo -e "${yellow}6. ubuntu.20.04-x64${plain}"
  echo -e "${yellow}7. ubuntu.18.04-x64${plain}"
  echo -e "${yellow}8. centos.7-x64${plain}"
  echo -e "${yellow}9. rhel.7-x64${plain}"
  echo -e "${yellow}10. rhel.8-x64${plain}"
  echo -e "${yellow}11. fedora.37-x64${plain}"

  arch=$(arch)

  

  read os_selector

  #1. debian.11-x64
  if [ $os_selector -eq "1" ]; then

    if [[ $arch == "x86_64" || $arch == "x64" || $arch == "amd64" ]]; then
      arch="amd64"
    else
      echo -e "${red}Your selected option does not match your processor architecture ${arch}${plain}" && exit 1
    fi

    os_command="apt"
    url_zip_file="https://github.com/ebrasha/abdal-4iproto-server-config/releases/download/v4/abdal-4iproto-server-config-debian.11-x64.zip"
  fi

  #2. debian.11-arm64
  if [ $os_selector -eq "2" ]; then

    if [[ $arch == "aarch64" || $arch == "arm64" ]]; then
      arch="arm64"
    else
      echo -e "${red}Your selected option does not match your processor architecture ${arch}${plain}" && exit 1
    fi

    os_command="apt"
    url_zip_file="https://github.com/ebrasha/abdal-4iproto-server-config/releases/download/v4/abdal-4iproto-server-config-debian.11-arm64.zip"
  fi

  # 3. debian.10-x64
  if [ $os_selector -eq "3" ]; then

    if [[ $arch == "x86_64" || $arch == "x64" || $arch == "amd64" ]]; then
      arch="amd64"
    else
      echo -e "${red}Your selected option does not match your processor architecture ${arch}${plain}" && exit 1
    fi

    os_command="apt"
    url_zip_file="https://github.com/ebrasha/abdal-4iproto-server-config/releases/download/v4/abdal-4iproto-server-config-debian.10-x64.zip"
  fi

  # 4. ubuntu.22.04-arm64
  if [ $os_selector -eq "4" ]; then
    if [[ $arch == "aarch64" || $arch == "arm64" ]]; then
      arch="arm64"
    else
      echo -e "${red}Your selected option does not match your processor architecture ${arch}${plain}" && exit 1
    fi

    os_command="apt"
    url_zip_file="https://github.com/ebrasha/abdal-4iproto-server-config/releases/download/v4/abdal-4iproto-server-config-ubuntu.22.04-arm64.zip"
  fi

  # 5. ubuntu.22.04-x64
  if [ $os_selector -eq "5" ]; then
    if [[ $arch == "x86_64" || $arch == "x64" || $arch == "amd64" ]]; then
      arch="amd64"
    else
      echo -e "${red}Your selected option does not match your processor architecture ${arch}${plain}" && exit 1
    fi

    os_command="apt"
    url_zip_file="https://github.com/ebrasha/abdal-4iproto-server-config/releases/download/v4/abdal-4iproto-server-config-ubuntu.22.04-x64.zip"
  fi

  # 6. ubuntu.20.04-x64
  if [ $os_selector -eq "6" ]; then
    if [[ $arch == "x86_64" || $arch == "x64" || $arch == "amd64" ]]; then
      arch="amd64"
    else
      echo -e "${red}Your selected option does not match your processor architecture ${arch}${plain}" && exit 1
    fi

    os_command="apt"
    url_zip_file="https://github.com/ebrasha/abdal-4iproto-server-config/releases/download/v4/abdal-4iproto-server-config-ubuntu.20.04-x64.zip"
  fi

  # 7. ubuntu.18.04-x64
  if [ $os_selector -eq "7" ]; then
    if [[ $arch == "x86_64" || $arch == "x64" || $arch == "amd64" ]]; then
      arch="amd64"
    else
      echo -e "${red}Your selected option does not match your processor architecture ${arch}${plain}" && exit 1
    fi
    os_command="apt"
    url_zip_file="https://github.com/ebrasha/abdal-4iproto-server-config/releases/download/v4/abdal-4iproto-server-config-ubuntu.18.04-x64.zip"
  fi

  # 8. centos.7-x64
  if [ $os_selector -eq "8" ]; then
    if [[ $arch == "x86_64" || $arch == "x64" || $arch == "amd64" ]]; then
      arch="amd64"
    else
      echo -e "${red}Your selected option does not match your processor architecture ${arch}${plain}" && exit 1
    fi

    os_command="yum"
    url_zip_file="https://github.com/ebrasha/abdal-4iproto-server-config/releases/download/v4/abdal-4iproto-server-config-centos.7-x64.zip"
  fi

  # 9. rhel.7-x64
  if [ $os_selector -eq "9" ]; then
    if [[ $arch == "x86_64" || $arch == "x64" || $arch == "amd64" ]]; then
      arch="amd64"
    else
      echo -e "${red}Your selected option does not match your processor architecture ${arch}${plain}" && exit 1
    fi

    os_command="yum"
    url_zip_file="https://github.com/ebrasha/abdal-4iproto-server-config/releases/download/v4/abdal-4iproto-server-config-rhel.7-x64.zip"
  fi

  # 10. rhel.8-x64
  if [ $os_selector -eq "10" ]; then
    if [[ $arch == "x86_64" || $arch == "x64" || $arch == "amd64" ]]; then
      arch="amd64"
    else
      echo -e "${red}Your selected option does not match your processor architecture ${arch}${plain}" && exit 1
    fi

    os_command="dnf"
    url_zip_file="https://github.com/ebrasha/abdal-4iproto-server-config/releases/download/v4/abdal-4iproto-server-config-rhel.8-x64.zip"
  fi

  # 11. fedora.37-x64
  if [ $os_selector -eq "11" ]; then
    if [[ $arch == "x86_64" || $arch == "x64" || $arch == "amd64" ]]; then
      arch="amd64"
    else
      echo -e "${red}Your selected option does not match your processor architecture ${arch}${plain}" && exit 1
    fi

    os_command="dnf"
    url_zip_file="https://github.com/ebrasha/abdal-4iproto-server-config/releases/download/v4/abdal-4iproto-server-config-fedora.37-x64.zip"
  fi

  $os_command update -y
  $os_command install wget curl tar zip unzip -y
  cd /usr/local/
  wget -N --no-check-certificate -O /usr/local/abdal-4iproto-server-config.zip $url_zip_file
  unzip /usr/local/abdal-4iproto-server-config.zip
  cd /usr/local/abdal-4iproto-server-config
  chmod +x Abdal4iProtoServerConfig
  rm -f /usr/local/bin/Abdal4iProtoServerConfig
  ln -s /usr/local/abdal-4iproto-server-config/Abdal4iProtoServerConfig /usr/local/bin
  mkdir /usr/local/abdal-4iproto-server-config-db/
  rm -f /usr/local/abdal-4iproto-server-config.zip

  clear
  echo " "
  echo -e "${red}---------------------------------${plain}"
  echo -e "${green}Abdal 4iProto Server Config installed successfully....${plain}"
  echo -e "${green}If need more options, let us know: Prof.Shafiei@Gmail.com${plain}"
  echo -e "${yellow}Use the Abdal4iProtoServerConfig command to manage the Abdal 4iProto${plain}"
  echo -e "${red}---------------------------------${plain}"

}

# check root
[[ $EUID -ne 0 ]] && echo -e "${red}mistake：${plain} This script must be run with the root user！\n" && exit 1

installer
