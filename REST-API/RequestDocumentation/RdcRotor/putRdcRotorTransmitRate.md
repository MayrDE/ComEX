# putRdcRotorTransmitRate

Set the rotor transmit rate in milliseconds.

Please note:

- This command is only available if rotor is ***not*** in `run mode`
- This is a temporary functionality. A ***gateway*** restart will reset this value

## Required service level

`Customer`

## Values

`Value`

Actually we accept values between 50ms and 1000ms in 50ms steps. Values below 50 will be limited. All values between e.g. 50ms and 100ms will be fixed to 50ms, values between 100ms and 150ms will be fixed to 100ms etc.

- type: integer
- format: uint16
- minimum: 50
- maximum: 1000
- multipleOf: 50
- possible values
  - 50
  - 100
  - 150
  - ...
  - 950
  - 1000

## Body

```json
{
  "Value": "50"
}
```

## Response

`202 Accepted`

Please use the [getRdcStatorCommandResult](../RdcStator/getRdcStatorCommandResult.md) function to check if the command has been executed successfully.

`400 Bad Request` if body parameters wrong

`401 Unauthorized` if service level is wrong

`503 Service Unavailable` if rotor is not connected to the gateway
