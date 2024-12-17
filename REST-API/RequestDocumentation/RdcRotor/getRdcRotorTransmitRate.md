# getRdcRotorTransmitRate

Get the rotor transmit rate in milliseconds.

## Required service level

`none`

## Values

`Value`

- type: integer
- format: uint16
- minimum: 50
- maximum: 1000
- multipleOf: 50
- possible return values
  - 50
  - 100
  - 150
  - ...
  - 950
  - 1000

## Body

`none`

## Response

`200 OK`

```json
{
  "Value": "50"
}
```

`503 Service Unavailable` if rotor is not connected to the gateway
