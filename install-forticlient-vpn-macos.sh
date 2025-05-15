#!/bin/bash

# CloudScale365 - FortiClient VPN Installer for macOS

DMG_NAME="FortiClientVPN_7.4.3.1761_OnlineInstaller.dmg"
MOUNT_POINT="/Volumes/FortiClientVPN"
DOWNLOAD_URL="https://github.com/cloudscale365-inc/msp/releases/download/v1.0.0/$DMG_NAME"

echo "Downloading FortiClient VPN installer..."
curl -L -o "$DMG_NAME" "$DOWNLOAD_URL"
if [ $? -ne 0 ]; then
  echo "Download failed."
  exit 1
fi

echo "Mounting DMG..."
hdiutil attach "$DMG_NAME" -mountpoint "$MOUNT_POINT" -quiet
if [ $? -ne 0 ]; then
  echo "Failed to mount DMG."
  exit 1
fi

echo "Installing FortiClient VPN..."
sudo installer -pkg "$MOUNT_POINT/FortiClientUpdate.pkg" -target /

echo "Unmounting DMG..."
hdiutil detach "$MOUNT_POINT" -quiet

echo "Cleaning up..."
rm -f "$DMG_NAME"

echo "Installation complete."
