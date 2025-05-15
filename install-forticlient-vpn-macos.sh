#!/bin/bash

set -e

echo "[*] Downloading FortiClient VPN installer..."
curl -L -o FortiClientVPN.dmg https://github.com/cloudscale365-inc/msp/releases/download/v1.0.0/FortiClientVPN_7.4.3.1761_OnlineInstaller.dmg

echo "[*] Mounting DMG..."
hdiutil attach FortiClientVPN.dmg -nobrowse -quiet

echo "[*] Installing FortiClient VPN..."
installer -pkg /Volumes/FortiClientVPN/FortiClientUpdate.pkg -target /

echo "[*] Unmounting DMG..."
hdiutil detach /Volumes/FortiClientVPN -quiet

echo "[*] Cleaning up..."
rm -f FortiClientVPN.dmg

echo "[✓] FortiClient VPN installation complete."
