#!/bin/bash

apt update
apt install wget curl tar zip unzip -y
cd /usr/local/
url_zip_file="https://raw.githubusercontent.com/ebrasha/abdal-4iproto-server-config/main/abdal-4iproto-server-config.zip"
wget -N --no-check-certificate -O /usr/local/abdal-4iproto-server-config.zip ${url_zip_file}
unzip /usr/local/abdal-4iproto-server-config.zip
 
cd /usr/local/abdal-4iproto-server-config
chmod +x Abdal4iProtoServerConfig
rm -f /usr/local/bin/Abdal4iProtoServerConfig
ln -s /usr/local/abdal-4iproto-server-config/Abdal4iProtoServerConfig /usr/local/bin

echo Abdal 4iProto Server Config installed successfully....
