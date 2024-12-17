# ROBA®-drive-checker cURL description

## Table of contents

1. [Introduction](#introduction)
1. [Preparation](#preparation)
1. [RdcRotor requests](#rdcrotor-requests)
1. [RdcStator requests](#rdcstator-requests)

## Introduction

This document describes the usage of cURL commands for the ROBA-drive-checker REST-API.

All commands are available for Unix and Windows command line.

## Preparation

To make these requests a little bit easier we suggest using a temporary variable in the command line. This will allow you to copy and paste the requests directly into the command line without changing the Uri (destination/gateway address) for each request.

If you don't want to use a temporary variable, you can replace all the variables in this document by the ROBA-drive-checker Uri.

>Please note that the Windows command line syntax **does not** work in the Windows PowerShell.

### Set a temporary variable for the session

Unix:

```bash
RDC_ADDR=http://rdc-2426d00331
```

Windows:

```bash
set RDC_ADDR=http://rdc-2426d00331
```

### Check if the variable has been set

Unix:

```bash
echo $RDC_ADDR
```

Windows:

```bash
echo %RDC_ADDR%
```

#### The output should be

```bash
http://rdc-2426d00331
```

## RdcRotor requests

### `GET` `/RdcRotor/FilterSelection`

Get the current torque filter selection of the rotor.

[Detailed description](../RequestDocumentation/RdcRotor/getRdcRotorFilterSelection.md)

Unix:

```bash
curl -X 'GET' $RDC_ADDR'/RdcRotor/FilterSelection' -H 'accept: */*' -H 'Content-Type: application/json'
```

Windows

```bash
curl -X "GET" "%RDC_ADDR%/RdcRotor/FilterSelection" -H "accept: */*" -H "Content-Type: application/json"
```

Example response:

```json
{
  "Value": "1"
}
```

---

### `PUT` `/RdcRotor/FilterSelection`

Set the torque filter selection of the rotor.

Please note:

- This command is only available if rotor is ***not*** in `run mode`
- You need to restart the rotor for changes to take effect

[Detailed description](../RequestDocumentation/RdcRotor/putRdcRotorFilterSelection.md)

Unix

```bash
curl -X 'PUT' $RDC_ADDR'/RdcRotor/FilterSelection' -H 'accept: */*' -H 'Content-Type: application/json' -d '{"Value": 1}'
```

Windows:

```bash
curl -X "PUT" "%RDC_ADDR%/RdcRotor/FilterSelection" -H "accept: */*" -H "Content-Type: application/json" -d "{\"Value\": 1}"
```

Example response:

`202 Accepted`

---

### `GET` `/RdcRotor/Id`

Get the rotor identification registers with Serial Number and Item Number.

[Detailed description](../RequestDocumentation/RdcRotor/getRdcRotorId.md)

Unix:

```bash
curl -X 'GET' $RDC_ADDR'/RdcRotor/Id' -H 'accept: */*' -H 'Content-Type: application/json'
```

Windows:

```bash
curl -X "GET" "%RDC_ADDR%/RdcRotor/Id" -H "accept: */*" -H "Content-Type: application/json"
```

Example response:

```json
{
  "SerialNumber": "2426D00331",
  "ItemNumber": "8298350"
}
```

---

### `GET` `/RdcRotor/ProcessData`

Get the latest process data of the rotor.

[Detailed description](../RequestDocumentation/RdcRotor/getRdcRotorProcessData.md)

Unix:

```bash
curl -X 'GET' $RDC_ADDR'/RdcRotor/ProcessData' -H 'accept: */*' -H 'Content-Type: application/json'
```

Windows:

```bash
curl -X "GET" "%RDC_ADDR%/RdcRotor/ProcessData" -H "accept: */*" -H "Content-Type: application/json"
```

Example response:

```json
{
  "Torque": "-0.31",
  "Speed": "0",
  "Temp": "29.00",
  "Minimum": "-2.65",
  "Maximum": "0.00",
  "Channel": "33",
  "Voltage": "42.98",
  "Timestamp": "1726465566413"
}
```

---

### `PUT` `/RdcRotor/Reset`

Rotor reset command with multiple choices.

Please note:

- This command is only available if rotor is ***not*** in `run mode`

[Detailed description](../RequestDocumentation/RdcRotor/putRdcRotorReset.md)

Unix:

```bash
curl -X 'PUT' $RDC_ADDR'/RdcRotor/Reset' -H 'accept: */*' -H 'Content-Type: application/json' -d '{"Value": 17}'
```

Windows:

```bash
curl -X "PUT" "%RDC_ADDR%/RdcRotor/Reset" -H "accept: */*" -H "Content-Type: application/json" -d "{\"Value\": 17}"
```

Example response:

`202 Accepted`

---

### `PUT` `/RdcRotor/Tara`

Set RDC Rotor torque Tara.

Please note:

- This command is only available if rotor is ***not*** in `run mode`
- ***This is a temporary functionality. A rotor restart will reset this value***

[Detailed description](../RequestDocumentation/RdcRotor/putRdcRotorTara.md)

Unix:

```bash
curl -X 'PUT' $RDC_ADDR'/RdcRotor/Tara' -H 'accept: */*' -H 'Content-Type: application/json' -d '{"Value": 1}'
```

Windows:

```bash
curl -X "PUT" "%RDC_ADDR%/RdcRotor/Tara" -H "accept: */*" -H "Content-Type: application/json" -d "{\"Value\": 1}"
```

Example response:

`202 Accepted`

---

### `GET` `/RdcRotor/TransmitRate`

Get the rotor transmit rate in milliseconds.

[Detailed description](../RequestDocumentation/RdcRotor/getRdcRotorTransmitRate.md)

Unix:

```bash
curl -X 'GET' $RDC_ADDR'/RdcRotor/TransmitRate' -H 'accept: */*' -H 'Content-Type: application/json'
```

Windows:

```bash
curl -X "GET" "%RDC_ADDR%/RdcRotor/TransmitRate" -H "accept: */*" -H "Content-Type: application/json"
```

Example response:

```json
{
  "Value": "50"
}
```

---

### `PUT` `/RdcRotor/TransmitRate`

Set the rotor transmit rate in milliseconds.

Please note:

- This command is only available if rotor is ***not*** in `run mode`
- This is a temporary functionality. A ***gateway*** restart will reset this value

[Detailed description](../RequestDocumentation/RdcRotor/putRdcRotorTransmitRate.md)

Unix:

```bash
curl -X 'PUT' $RDC_ADDR'/RdcRotor/TransmitRate' -H 'accept: */*' -H 'Content-Type: application/json' -d '{"Value": 500}'
```

Windows:

```bash
curl -X "PUT" "%RDC_ADDR%/RdcRotor/TransmitRate" -H "accept: */*" -H "Content-Type: application/json" -d "{\"Value\": 500}"
```

Example response:

`202 Accepted`

---

### `GET` `/RdcRotor/Version`

Get the rotor hardware and software versions.

[Detailed description](../RequestDocumentation/RdcRotor/getRdcRotorVersion.md)

Unix:

```bash
curl -X 'GET' $RDC_ADDR'/RdcRotor/Version' -H 'accept: */*' -H 'Content-Type: application/json'
```

Windows:

```bash
curl -X "GET" "%RDC_ADDR%/RdcRotor/Version" -H "accept: */*" -H "Content-Type: application/json"
```

Example response:

```json
{
  "HwVersion": "0.2.0.0",
  "SwVersion": "1.0.3"
}
```

---

## RdcStator requests

### `GET` `/RdcStator/AnalogRange`

Get the gateway analog output range.

[Detailed description](../RequestDocumentation/RdcStator/getRdcStatorAnalogRange.md)

Unix:

```bash
curl -X 'GET' $RDC_ADDR'/RdcStator/AnalogRange' -H 'accept: */*' -H 'Content-Type: application/json'
```

Windows

```bash
curl -X "GET" "%RDC_ADDR%/RdcStator/AnalogRange" -H "accept: */*" -H "Content-Type: application/json"
```

Example response:

```json
{
  "Value": "1"
}
```

---

### `PUT` `/RdcStator/AnalogRange`

Get the gateway analog output range.

[Detailed description](../RequestDocumentation/RdcStator/putRdcStatorAnalogRange.md)

Unix:

```bash
curl -X 'PUT' $RDC_ADDR'/RdcStator/AnalogRange' -H 'accept: */*' -H 'Content-Type: application/json' -d '{"Value": 0}'
```

Windows

```bash
curl -X "PUT" "%RDC_ADDR%/RdcStator/AnalogRange" -H "accept: */*" -H "Content-Type: application/json" -d "{\"Value\": 0}"
```

Example response:

`204 No Content`

---

### `GET` `/RdcStator/CommandResult`

Get the last rotor command result. Use this request to check the result of every rotor command.

[Detailed description](../RequestDocumentation/RdcStator/getRdcStatorCommandResult.md)

Unix:

```bash
curl -X 'GET' $RDC_ADDR'/RdcStator/CommandResult' -H 'accept: */*' -H 'Content-Type: application/json'
```

Windows

```bash
curl -X "GET" "%RDC_ADDR%/RdcStator/CommandResult" -H "accept: */*" -H "Content-Type: application/json"
```

Example response:

```json
{
  "Value": "2"
}
```

---

### `GET` `/RdcStator/Id`

Get the gateway identification registers with Serial Number and Item Number.

[Detailed description](../RequestDocumentation/RdcStator/getRdcStatorId.md)

Unix:

```bash
curl -X 'GET' $RDC_ADDR'/RdcStator/Id' -H 'accept: */*' -H 'Content-Type: application/json'
```

Windows:

```bash
curl -X "GET" "%RDC_ADDR%/RdcStator/Id" -H "accept: */*" -H "Content-Type: application/json"
```

Example response:

```json
{
  "SerialNumber": "2426D00331",
  "ItemNumber": "8298350"
}
```

---

### `PUT` `/RdcStator/Pairing`

Start RDC Stator Pairing.

[Detailed description](../RequestDocumentation/RdcStator/putRdcStatorPairing.md)

Unix:

```bash
curl -X 'PUT' $RDC_ADDR'/RdcStator/Pairing' -H 'accept: */*' -H 'Content-Type: application/json'
```

Windows

```bash
curl -X "PUT" "%RDC_ADDR%/RdcStator/Pairing" -H "accept: */*" -H "Content-Type: application/json"
```

Example response:

`204 No Content`

---

### `GET` `/RdcStator/Ping`

Send ping to stator. You can use this request to check if the stator is online or not. If you want to check the state of the rotor, use the `getRdcStatorRotorState` request instead.

[Detailed description](../RequestDocumentation/RdcStator/getRdcStatorPing.md)

Unix:

```bash
curl -X 'GET' $RDC_ADDR'/RdcStator/Ping' -H 'accept: */*' -H 'Content-Type: application/json'
```

Windows:

```bash
curl -X "GET" "%RDC_ADDR%/RdcStator/Ping" -H "accept: */*" -H "Content-Type: application/json"
```

Example response:

`200 OK`

---

### `PUT` `/RdcStator/Reset`

Send a gateway reset/restart request. This will restart the gateway immediately.

[Detailed description](../RequestDocumentation/RdcStator/putRdcStatorReset.md)

Unix:

```bash
curl -X 'PUT' $RDC_ADDR'/RdcStator/Reset' -H 'accept: */*' -H 'Content-Type: application/json'
```

Windows

```bash
curl -X "PUT" "%RDC_ADDR%/RdcStator/Reset" -H "accept: */*" -H "Content-Type: application/json"
```

Example response:

`202 Accepted`

---

### `GET` `/RdcStator/RotorState`

Get the current rotor connection state.

[Detailed description](../RequestDocumentation/RdcStator/getRdcStatorRotorState.md)

Unix:

```bash
curl -X 'GET' $RDC_ADDR'/RdcStator/RotorState' -H 'accept: */*' -H 'Content-Type: application/json'
```

Windows:

```bash
curl -X "GET" "%RDC_ADDR%/RdcStator/RotorState" -H "accept: */*" -H "Content-Type: application/json"
```

Example response:

```json
{
  "Value": 7
}
```

---

### `GET` `/RdcStator/RunMode`

Get RDC Stator run mode status.

[Detailed description](../RequestDocumentation/RdcStator/getRdcStatorRunMode.md)

Unix:

```bash
curl -X 'GET' $RDC_ADDR'/RdcStator/RunMode' -H 'accept: */*' -H 'Content-Type: application/json'
```

Windows

```bash
curl -X "GET" "%RDC_ADDR%/RdcStator/RunMode" -H "accept: */*" -H "Content-Type: application/json"
```

Example response:

```json
{
  "Value": 0
}
```

---

### `PUT` `/RdcStator/RunMode`

Toggle RDC Stator run mode. To check if run mode should be changed use the `getRdcStatorRunMode` request.

[Detailed description](../RequestDocumentation/RdcStator/putRdcStatorRunMode.md)

Unix:

```bash
curl -X 'PUT' $RDC_ADDR'/RdcStator/RunMode' -H 'accept: */*' -H 'Content-Type: application/json'
```

Windows

```bash
curl -X "PUT" "%RDC_ADDR%/RdcStator/RunMode" -H "accept: */*" -H "Content-Type: application/json"
```

Example response:

`204 No Content`

---

### `GET` `/RdcStator/Version`

Get the gateway hardware and software versions.

[Detailed description](../RequestDocumentation/RdcStator/getRdcStatorVersion.md)

Unix:

```bash
curl -X 'GET' $RDC_ADDR'/RdcStator/Version' -H 'accept: */*' -H 'Content-Type: application/json'
```

Windows

```bash
curl -X "GET" "%RDC_ADDR%/RdcStator/Version" -H "accept: */*" -H "Content-Type: application/json"
```

Example response:

```json
{
  "HwVersion": "1.0.1.0",
  "SwVersion": "1.0.1"
}
```

---

[Back to REST-API overview](../README.md)
