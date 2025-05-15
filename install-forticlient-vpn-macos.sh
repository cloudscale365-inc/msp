#!/bin/bash

# CloudScale365 - FortiClient VPN Installer for macOS

DMG_NAME="FortiClientVPN_7.4.3.1761_OnlineInstaller.dmg"
DOWNLOAD_DIR="$HOME/Downloads"
MOUNT_POINT="/Volumes/FortiClientInstaller"
DOWNLOAD_URL="https://github.com/cloudscale365-inc/msp/releases/download/v1.0.0/$DMG_NAME"

cd "$DOWNLOAD_DIR" || exit 1

echo "Downloading FortiClient VPN installer to $DOWNLOAD_DIR..."
curl -L -o "$DMG_NAME" "$DOWNLOAD_URL"
if [ $? -ne 0 ]; then
  echo "Download failed. Check your network or URL."
  exit 1
fi

echo "Mounting DMG..."
hdiutil attach "$DMG_NAME" -mountpoint "$MOUNT_POINT" -quiet
if [ $? -ne 0 ]; then
  echo "Failed to mount DMG."
  exit 1
fi

echo "Looking for installer package..."
PKG_PATH=$(find "$MOUNT_POINT" -name "*.pkg" -type f | head -n 1)

if [ -z "$PKG_PATH" ]; then
  echo "No installer package found in $MOUNT_POINT. Exiting."
  hdiutil detach "$MOUNT_POINT" -quiet
  rm -f "$DMG_NAME"
  exit 1
fi

echo "Installing FortiClient VPN..."
sudo installer -pkg "$PKG_PATH" -target /

echo "Unmounting DMG..."
hdiutil detach "$MOUNT_POINT" -quiet

echo "Cleaning up..."
rm -f "$DMG_NAME"

echo "✅ FortiClient VPN installation complete."
