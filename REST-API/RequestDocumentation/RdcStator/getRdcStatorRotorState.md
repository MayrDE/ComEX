# getRdcStatorRotorState

Get the current rotor connection state.

## Required service level

`none`

## Values

`Value`

- type: integer
- format: uint8
- minimum: 0
- maximum: 11
- possible values
  - 0 = Initialize_RF,
  - 1 = Initialize_Self,
  - 2 = Init_Failed,
  - 3 = NotPaired,
  - 4 = Pairing,
  - 5 = PairingFailed,
  - 6 = NotConnected,
  - 7 = Connected,
  - 8 = RunMode,
  - 9 = RotorUpdate,
  - 10 = RotorUpdateFailed,
  - 11 = Wait4CommandResponse

## Body

`none`

## Response

`200 OK`

```json
{
  "Value": 7
}
```
