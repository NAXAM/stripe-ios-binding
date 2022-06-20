#!/bin/bash

export SDK=iphoneos15.5

function bind {
    echo "$1 artifacts/$2.xcframework/ios-arm64/$2.framework/Headers/"

    if [ $3 == '1' ]
    then
        sharpie bind --sdk=$SDK \
            --output="libs/$1.iOS" \
            --namespace="$1" \
            --scope="$PWD/artifacts/$2.xcframework/ios-arm64/$2.framework/Headers/" \
            "$PWD/artifacts/$2.xcframework/ios-arm64/$2.framework/Headers/$2.h"
    elif [ $3 == '2' ]
    then
        sharpie bind --sdk=$SDK \
            --output="libs/$1.iOS" \
            --namespace="$1" \
            --scope="$PWD/artifacts/$2.xcframework/ios-arm64/$2.framework/Headers/" \
            "$PWD/artifacts/$2.xcframework/ios-arm64_armv7/$2.framework/Headers/$2.h"
    else
        sharpie bind --sdk=$SDK \
            --output="libs/$1.iOS" \
            --namespace="$1" \
            --scope="$PWD/artifacts/$2.xcframework/ios-arm64/$2.framework/Headers/" \
            "$PWD/artifacts/$2.xcframework/ios-arm64/$2.framework/Headers/$2-Swift.h"
    fi
}

# bind StripeApplePay StripeApplePay 0
bind Stripe Stripe 0
# bind Stripe3DS2 Stripe3DS2 1
# bind StripeCameraCore StripeCameraCore 0
# bind StripeCardScan StripeCardScan 0
# bind StripeCore StripeCore 0
# bind StripeFinancialConnections StripeFinancialConnections 0
# bind StripeIdentity StripeIdentity 0
# bind StripeUICore StripeUICore 0