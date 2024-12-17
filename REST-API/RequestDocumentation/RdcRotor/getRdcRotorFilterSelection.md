# getRdcRotorFilterSelection
  
Get the current torque filter selection of the rotor.
  
## Required service level
  
`none`
  
## Values
  
`Value`

- type: integer
- format: uint8
- minimum: 0
- maximum: 5
- possible values
  - 0 = 1Hz
  - 1 = 10Hz
  - 2 = 100Hz
  - 3 = 200Hz
  - 4 = 500Hz
  - 5 = 1000Hz
  
## Body
  
`none`
  
## Response
  
`200 OK`

```json
{
  "Value": "1"
}
```
  
`503 Service Unavailable` if rotor is not connected to the gateway
