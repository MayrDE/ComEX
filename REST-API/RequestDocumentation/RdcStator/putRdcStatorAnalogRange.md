# putRdcStatorAnalogRange

Set the gateway analog output range.

## Required service level

`Service`

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

```json
{
  "Value": 1
}
```

## Response

`204 No Content` on success

`400 Bad Request` if body parameters wrong

`401 Unauthorized` if service level is wrong
