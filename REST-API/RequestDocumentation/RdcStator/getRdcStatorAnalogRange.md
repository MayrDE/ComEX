# getRdcStatorAnalogRange

Get the gateway analog output range.

## Required service level

`none`

## Values

`Value`

- type: integer
- format: uint8
- minimum: 0
- maximum: 1
- default: 1
- possible values
  - 0 = 0-10V
  - 1 = 0-20mA

## Body

`none`

## Response

`200 OK`

```json
{
  "Value": 1
}
```
