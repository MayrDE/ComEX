
# Value conversion description

Valid for Modbus and WebSocket/RawDataLogger only! All other torque values (REST API etc.) are already converted.

## Torque value conversion

The actual torque is transmitted by the rotor as a raw 16 bit value to the gateway.

To get the torque in Nm you need to:

- request the `MaximumTorque` of the current rotor [via REST API request](../REST-API/README.md)
- or read the calibration torque value from the nameplate of the rotor
- divide the `MaximumTorque` by `30000` to get the scaling factor (needs to be done only once)
- multiply raw Torque by your scaling factor.

Example:

```c
double maxTorque = 190; // Nm
double scalingFactor = maxTorque / 30000.0; // = 0,0063333333333333
double torqueNm = PayloadFrame.ProcessData.Torque * scalingFactor;
```

## Temperature value conversion

This value must be multiplied by 0.1 (or divided by 10) to get the actual temperature.

## Input voltage value conversion

This value must be multiplied by 0.001 (or divided by 1000) to get the actual voltage.
