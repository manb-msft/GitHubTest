#!/usr/bin/env bash

# Download MobileVLCKit binary
echo "Change directory to VLCKit.iOS, downloading from https://rocdevdata.blob.core.windows.net/config/app_build_files/MobileVLCKit"
echo $APPCENTER_SOURCE_DIRECTORY
cd "$APPCENTER_SOURCE_DIRECTORY"
curl -O "https://rocdevdata.blob.core.windows.net/config/app_build_files/MobileVLCKit"
echo "finished"
find $APPCENTER_SOURCE_DIRECTORY -regex '.*MobileVLCKit.*' -exec echo {} \;
