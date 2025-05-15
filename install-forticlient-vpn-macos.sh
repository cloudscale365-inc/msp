#!/bin/bash

# CloudScale365 - FortiClient VPN Installer for macOS

DMG_NAME="FortiClientVPN_7.4.3.1761_OnlineInstaller.dmg"
DOWNLOAD_DIR="$HOME/Downloads"
MOUNT_POINT="$DOWNLOAD_DIR/$DMG_NAME"
DOWNLOAD_URL="https://github.com/cloudscale365-inc/msp/releases/download/v1.0.0/$DMG_NAME"

cd "$DOWNLOAD_DIR" || exit 1

echo "Downloading FortiClient VPN installer to $DOWNLOAD_DIR..."
curl -L -o "$DMG_NAME" "$DOWNLOAD_URL"
if [ $? -ne 0 ]; then
  echo "Download failed. Check your network or URL."
  exit 1
fi

echo "Mounting DMG..."
hdiutil attach "$DOWNLOAD_DIR/$DMG_NAME"
if [ $? -ne 0 ]; then
  echo "Failed to mount DMG."
  exit 1
fi

echo "Looking for fctupdate installer..."
# Wait for fctupdate to appear (max 90 seconds)
RETRIES=0
MAX_RETRIES=18
SLEEP_INTERVAL=5

while [[ $RETRIES -lt $MAX_RETRIES ]]; do
  PKG_PATH=$(find /System/Volumes/Data/private -name Install.mpkg 2>/dev/null | grep fctupdate | head -n 1)
  if [[ -n "$PKG_PATH" ]]; then
    echo "Found installer package: $PKG_PATH"
    break
  fi
  sleep $SLEEP_INTERVAL
  ((RETRIES++))
done

if [ -z "$PKG_PATH" ]; then
  echo "No installer package found. Exiting."
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
