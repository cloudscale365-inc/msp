#!/bin/bash

set -euo pipefail

# Define variables
DMG_URL="https://github.com/cloudscale365-inc/msp/releases/download/v1.0.0/FortiClientVPN_7.4.3.1761_OnlineInstaller.dmg"
DMG_NAME="FortiClientVPN_7.4.3.1761_OnlineInstaller.dmg"
MOUNT_POINT="/Volumes/FortiClientVPN"

echo "[*] Downloading FortiClient VPN installer..."
curl -L -o "$DMG_NAME" "$DMG_URL"

echo "[*] Mounting DMG..."
hdiutil attach "$DMG_NAME" -mountpoint "$MOUNT_POINT" -quiet

echo "[*] Installing FortiClient VPN..."
sudo installer -pkg "$MOUNT_POINT/FortiClientUpdate.pkg" -target /

echo "[*] Unmounting and cleaning up..."
hdiutil detach "$MOUNT_POINT" -quiet
rm -f "$DMG_NAME"

echo "[✓] FortiClient VPN installation complete."
