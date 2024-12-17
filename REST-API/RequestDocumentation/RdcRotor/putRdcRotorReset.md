# putRdcRotorReset

Rotor reset command with multiple choices. See Value description for details.

## Required service level

`Customer`

## Values

`Value`

- type: integer
- format: uint8
- minimum: 0
- maximum: 255
- possible values:
  - 0x11 (dec 17) = Reset Min/Max
  - 0xAA (dec 170) = Restart rotor

## Body

```json
{
  "Value": 17
}
```

## Response

`202 Accepted`

Please use the [getRdcStatorCommandResult](../RdcStator/getRdcStatorCommandResult.md) function to check if the command has been executed successfully.

`400 Bad Request` if body parameters wrong

`401 Unauthorized` if service level is wrong

`503 Service Unavailable` if rotor is not connected to the gateway
