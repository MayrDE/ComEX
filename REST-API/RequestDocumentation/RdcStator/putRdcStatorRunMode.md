# putRdcStatorRunMode

Toggle RDC Stator run mode. To check if run mode should be changed use the [getRdcStatorRunMode](getRdcStatorRunMode.md) request.

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

`none`

## Response

`204 No Content` on success

`400 Bad Request` if body parameters wrong

`401 Unauthorized` if service level is wrong
