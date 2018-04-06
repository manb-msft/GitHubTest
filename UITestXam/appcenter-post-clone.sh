#!/usr/bin/env bash

# Download MobileVLCKit binary
echo "Change directory to VLCKit.iOS, downloading from https://rocdevdata.blob.core.windows.net/config/app_build_files/MobileVLCKit"
cd "$APPCENTER_SOURCE_DIRECTORY/VLC/VLCKit.iOS" && {curl -O "https://rocdevdata.blob.core.windows.net/config/app_build_files/MobileVLCKit"; echo "Download finished"}
