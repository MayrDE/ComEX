# getRdcRotorId

Get the rotor identification registers with Serial Number and Item Number.

## Required service level

`none`

## Values

`SerialNumber`

This is the serial number of the rotor

- type: string
- minLength: 7
- maxLength: 16

`ItemNumber`

This is the item number of the rotor

- type: string
- minLength: 7
- maxLength: 16

## Body

`none`

## Response

`200 OK`

```json
{
  "SerialNumber": "2426D00331",
  "ItemNumber": "8298350"
}
```

`503 Service Unavailable` if rotor is not connected to the gateway
