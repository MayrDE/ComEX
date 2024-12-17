# putRdcRotorTara

Set RDC Rotor tara.

Please note:

- This command is only available if rotor is ***not*** in `run mode`
- ***This is a temporary functionality. A rotor restart will reset this value***

## Required service level

`Customer`

## Values

`Value`

- type: integer
- format: uint8
- minimum: 0
- maximum: 1
- possible values
  - 0 = Off
  - 1 = On

## Body

```json
{
  "Value": 1
}
```

## Response

`202 Accepted`

Please use the [getRdcStatorCommandResult](../RdcStator/getRdcStatorCommandResult.md) function to check if the command has been executed successfully.

`400 Bad Request` if body parameters wrong

`401 Unauthorized` if service level is wrong

`503 Service Unavailable` if rotor is not connected to the gateway
