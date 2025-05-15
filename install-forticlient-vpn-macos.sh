#!/bin/bash

set -e

FORTICLIENT_URL="https://github.com/cloudscale365-inc/msp/releases/download/v1.0.0/FortiClientVPN_7.4.3.1761_OnlineInstaller.dmg"
DMG_NAME="FortiClientVPN_Installer.dmg"
MOUNT_POINT="/Volumes/FortiClientVPN"
PKG_NAME="FortiClientUpdate.pkg"

echo "[*] Downloading FortiClient VPN installer..."
curl -L -o "$DMG_NAME" "$FORTICLIENT_URL"

echo "[*] Mounting DMG..."
hdiutil attach "$DMG_NAME" -nobrowse -quiet

echo "[*] Installing FortiClient VPN..."
sudo installer -pkg "$MOUNT_POINT/$PKG_NAME" -target /

echo "[*] Unmounting and cleaning up..."
hdiutil detach "$MOUNT_POINT" -quiet
rm -f "$DMG_NAME"

echo "[✓] FortiClient VPN installation complete."
