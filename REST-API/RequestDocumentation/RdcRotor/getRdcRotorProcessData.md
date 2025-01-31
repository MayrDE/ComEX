# getRdcRotorProcessData

Get the latest process data of the rotor.

## Required service level

`none`

## Values

`Torque`

This is the averaged actual torque value (calculated by the rotor)

- type: number
- format: float

`Speed`

This is the rotor speed in rpm and can be a positive or negative value. The maximum speed depends on the rotor size.

- type: integer
- format: int16

`Temp`

This is the rotor cpu temperature

- type: number
- format: float

`Minimum`

This is the unfiltered minimum torque hold value (spike) from -(max torque) to 0. Can be reset by RdcRotorResetSelection 0x11 Reset Min/Max

- type: number
- format: float

`Maximum`

This is the unfiltered maximum torque hold value (spike) from 0 to (max torque). Can be reset by RdcRotorResetSelection 0x11 Reset Min/Max

- type: number
- format: float

`Channel`

This is the actual communication channel of the radio modules on gateway and rotor

- type: integer
- format: uint8
- minimum: 0
- maximum: 37

`Voltage`

This is the induced supply voltage of the rotor

- type: number
- format: float

`Timestamp`

This is the unix timestamp of this message in milliseconds.

- type: integer
- format: int64

## Body

`none`

## Response

`200 OK`

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

`503 Service Unavailable` if rotor is not connected to the gateway
