# putRdcStatorPairing

Start RDC Stator Pairing.

> Please note!
>
> Once pairing is started it can't be stopped until pairing has been either successful or failed.

You can use the [getRdcStatorRotorState](getRdcStatorRotorState.md) request to check the current state of the rotor before/during/after pairing to see if pairing is needed or not.

## Required service level

`Service`

## Values

`none`

## Body

`none`

## Response

`202 Accepted`

or

`429 Too Many Requests` if request has been send again during active pairing.

`401 Unauthorized` if service level is wrong
