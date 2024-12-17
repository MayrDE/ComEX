# getRdcStatorRunMode

Get RDC Stator run mode status.

## Required service level

`none`

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

`200 OK`

```json
{
  "Value": 0
}
```

or

timeout
