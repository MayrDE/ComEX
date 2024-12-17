# getRdcStatorId

Get the gateway identification registers with Serial Number and Item Number.

## Required service level

`none`

## Values

`SerialNumber`

This is the serial number of the gateway

- type: string
- minLength: 7
- maxLength: 16

`ItemNumber`

This is the item number of the gateway

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