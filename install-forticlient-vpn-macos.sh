#!/bin/bash

# CloudScale365 FortiClient VPN Installer (macOS Safe)

DMG_NAME="FortiClientVPN_7.4.3.1761_OnlineInstaller.dmg"
DMG_PATH="$HOME/Downloads/$DMG_NAME"
DOWNLOAD_URL="https://github.com/cloudscale365-inc/msp/releases/download/v1.0.0/$DMG_NAME"

echo "Downloading FortiClient VPN installer to ~/Downloads..."
curl -L -o "$DMG_PATH" "$DOWNLOAD_URL"
if [ $? -ne 0 ]; then
  echo "Download failed. Exiting."
  exit 1
fi

echo "Mounting DMG..."
MOUNT_OUTPUT=$(hdiutil attach "$DMG_PATH" | grep Volumes)
MOUNT_POINT=$(echo "$MOUNT_OUTPUT" | awk '{print $3}')
if [ ! -d "$MOUNT_POINT" ]; then
  echo "Failed to mount DMG. Exiting."
  exit 1
fi

echo "Looking for .pkg inside mounted volume..."
PKG_PATH=$(find "$MOUNT_POINT" -name "*.pkg" | head -n 1)
if [ ! -f "$PKG_PATH" ]; then
  echo "No installer package found. Exiting."
  hdiutil detach "$MOUNT_POINT"
  exit 1
fi

echo "Installing FortiClient VPN..."
sudo installer -pkg "$PKG_PATH" -target /

echo "Unmounting DMG..."
hdiutil detach "$MOUNT_POINT"

echo "Cleaning up..."
rm -f "$DMG_PATH"

echo "FortiClient VPN installation complete."
