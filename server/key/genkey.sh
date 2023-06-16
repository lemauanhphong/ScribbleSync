#!/bin/bash
openssl genpkey -algorithm Ed25519 -out ed25519key.pem
openssl pkey -in ed25519key.pem -pubout -out ed25519pubkey.pem