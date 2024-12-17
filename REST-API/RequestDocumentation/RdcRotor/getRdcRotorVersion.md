# getRdcRotorVersion

Get the rotor hardware and software versions.

## Required service level

`none`

## Values

`HwVersion`

This is the hardware version of the rotor.

- type: string
- maxLength: 15
- minLength: 7
  
`SwVersion`

This is the software version of the rotor.

- type: string
- maxLength: 11
- minLength: 5

## Body

`none`

## Response

`200 OK`

```json
{
  "HwVersion": "0.2.0.0",
  "SwVersion": "1.0.3"
}
```

`503 Service Unavailable` if rotor is not connected to the gateway
