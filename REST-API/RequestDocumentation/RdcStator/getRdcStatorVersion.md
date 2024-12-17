# getRdcStatorVersion

Get the gateway hardware and software versions.

## Required service level

`none`

## Values

`HwVersion`

This is the hardware version of the gateway.

- type: string
- maxLength: 15
- minLength: 7
  
`SwVersion`

This is the software version of the gateway.

- type: string
- maxLength: 11
- minLength: 5

## Body

`none`

## Response

`200 OK`

```json
{
  "HwVersion": "1.0.1.0",
  "SwVersion": "1.0.1"
}
```