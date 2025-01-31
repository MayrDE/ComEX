# getRdcStatorCommandResult

Get the last rotor command result. Use this request to check the result of every rotor command.

> Please note!
>
> The state machine which sends the requests to the rotor depends on the selected `transmit rate`. A request from the gateway to the rotor is only allowed within the first 3 milliseconds after a packet has been received from the rotor.
>
> Therefore you should wait at least `transmit rate` milliseconds before sending a [getRdcStatorCommandResult](../RdcStator/getRdcStatorCommandResult.md) request after sending a command to the rotor. Otherwise you would probably request the result of the previous command.

## Required service level

`none`

## Values

`Value`

- type: integer
- format: int8
- minimum: -1
- maximum: 4
- possible values
  - -1 = NONE (no result yet)
  - 0 = NACK (command request not acknowledged if request is malformed or not possible at the moment)
  - 1 = ACK (command acknowledged but not finished yet. Note: not all requests wil send FIN. For example a rotor restart can only send ACK)
  - 2 = FIN (rotor command finished successful)
  - 3 = ERR (rotor command error because command failed for some reason)
  - 4 = BUSY (already working on a request)

## Body

`none`

## Response

`200 OK`

```json
{
  "Value": "2"
}
```
