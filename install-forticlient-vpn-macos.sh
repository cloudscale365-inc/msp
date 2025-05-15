#!/bin/bash

set -e

APP_NAME="FortiClient VPN"
DMG_NAME="FortiClientVPN_7.4.3.1761_OnlineInstaller.dmg"
DOWNLOAD_URL="https://github.com/cloudscale365-inc/msp/releases/download/v1.0.0/FortiClientVPN_7.4.3.1761_OnlineInstaller.dmg"

echo "[*] Downloading $APP_NAME installer..."
curl -L "$DOWNLOAD_URL" -o "$DMG_NAME"

echo "[*] Mounting DMG..."
MOUNT_DIR=$(hdiutil attach "$DMG_NAME" | grep Volumes | awk '{print $3}')

echo "[*] Installing $APP_NAME..."
sudo installer -pkg "$MOUNT_DIR/FortiClientUpdate.pkg" -target /

echo "[*] Unmounting and cleaning up..."
hdiutil detach "$MOUNT_DIR"
rm "$DMG_NAME"

echo "[✓] $APP_NAME installation complete."
