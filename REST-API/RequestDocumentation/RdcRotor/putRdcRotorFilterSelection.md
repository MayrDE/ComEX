# putRdcRotorFilterSelection

Set the torque filter selection of the rotor.

Please note:

- This command is only available if rotor is ***not*** in `run mode`
- You need to restart the rotor for changes to take effect

## Required service level

`Service`

## Values

`Value`

- type: integer
- format: uint8
- minimum: 0
- maximum: 5
- possible values
  - 0 = 1Hz
  - 1 = 10Hz
  - 2 = 100Hz
  - 3 = 200Hz
  - 4 = 500Hz
  - 5 = 1000Hz

## Body

```json
{
  "Value": "1"
}
```

## Response

`202 Accepted`

Please use the [getRdcStatorCommandResult](../RdcStator/getRdcStatorCommandResult.md) function to check if the command has been executed successfully.

`400 Bad Request` if body parameters wrong

`401 Unauthorized` if service level is wrong

`503 Service Unavailable` if rotor is not connected to the gateway
