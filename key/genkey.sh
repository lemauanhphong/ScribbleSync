#!/bin/bash
echo -e "# Don't add passphrase"
ssh-keygen -t rsa -b 4096 -m PEM -E SHA512 -f jwtRS512.key -N ""
openssl rsa -in jwtRS512.key -pubout -outform PEM -out jwtRS512.key.pub