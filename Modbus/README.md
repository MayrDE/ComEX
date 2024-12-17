# ROBA®-drive-checker MODBUS TCP register description

## Table of contents

1. [Synonyms and abbreviations](#synonyms-and-abbreviations)
1. [Basic MODBUS Data model](#basic-modbus-data-model)
1. [Function Code Categories](#function-code-categories)
1. [Gateway Registers](#gateway-registers)
1. [Rotor Registers](#rotor-registers)

## Synonyms and abbreviations

| Abbreviation | Description |
| ------ | ------ |
| **ro** | read only |
| **rw** | read write |

---

## Basic MODBUS Data model

MODBUS bases its data model on a series of tables that have distinguishing characteristics. The four primary tables are:

| Register number | Register address hex | Object type | Access mode | Name |
| ------ | ------ | ------ | ------ | ------ |
| 00001-09999 | 0000 to 270E | Single bit | rw | Discrete Output Coils |
| 10001-19999 | 0000 to 270E | Single bit | ro | Discrete Input Contacts |
| 30001-39999 | 0000 to 270E | 16-bit word | rw | Holding Registers |
| 40001-49999 | 0000 to 270E | 16-bit word | ro | Input Registers |

---

The distinctions between inputs and outputs, and between bit-addressable and word-addressable data items, do not imply any application behavior.

It is perfectly acceptable, and very common, to regard all four tables as overlaying one another, if this is the most natural interpretation on the target machine in question.

For each of the primary tables, the protocol allows individual selection of 65536 data items, and the operations of read or write of those items are designed to span multiple consecutive data items up to a data size limit which is dependent on the transaction function code.

It’s obvious that all the data handled via MODBUS (bits, registers) must be located in device application memory. But physical address in memory should not be confused with data reference. The only requirement is to link data reference with physical address.

MODBUS logical reference numbers, which are used in MODBUS functions, are unsigned integer indices starting at zero.

&uarr; [back to top](#table-of-contents)

## Function Code Categories

There are three categories of MODBUS Functions codes.

### Public Function Codes

- Are well defined function codes
- guaranteed to be unique
- validated by the MODBUS.org community
- publicly documented
- have available conformance test
- includes both defined public assigned function codes as well as unassigned function codes reserved for future use.

### User-Defined Function Codes

- there are two ranges of user-defined function codes, i.e. 65 to 72 and from 100 to 110 decimal.
- user can select and implement a function code that is not supported by the specification.
- there is no guarantee that the use of the selected function code will be unique
- if the user wants to re-position the functionality as a public function code, he must initiate an RFC to introduce the change into the public category and to have a new public function code assigned.
- MODBUS Organization, Inc expressly reserves the right to develop the proposed RFC.

### Reserved Function Codes

- Function Codes currently used by some companies for legacy products and that are not available for public use.
- Informative Note: The reader is asked to refer to Annex A (Informative) MODBUS RESERVED FUNCTION CODES, SUBCODES AND MEI TYPES

For more information about the Modbus protocol please refer to [the Modbus documentation](https://modbus.org/specs.php)

&uarr; [back to top](#table-of-contents)

## Gateway registers

### Gateway Command Registers (coils) FC01 / FC05

| **Register name** | **Register address hex** | **Register address dec** | **Size in bytes** | **Size in words** | **Read** |  **Write** | **Description** |
| ------ | ------ | ------ | ------ | ------ | ------ | ------ | ------ |
| Pairing Command  | 0x0400 | 1024 | 2 | 1 |      Yes | Yes | [link](ModbusDataStructure.md#gateway-pairing-command) |
| Restart Command  | 0x0401 | 1025 | 2 | 1 | always 0 | Yes | [link](ModbusDataStructure.md#gateway-restart-command) |
| Run Mode Command | 0x0402 | 1026 | 2 | 1 |      Yes | Yes | [link](ModbusDataStructure.md#gateway-run-mode-command) |

### Gateway Indentification Holding Registers (read only) FC03

| **Register name** | **Register address hex** | **Register address dec** | **Size in bytes** | **Size in words** | **Read** |  **Write** | **Description** |
| ------ | ------ | ------ | ------ | ------ | ------ | ------ | ------ |
| Hardware Version Register  | 0x0500 | 1280 |  4 | 2 | Yes |  No | [link](ModbusDataStructure.md#hardware-version-register) |
| Firmware Version Register  | 0x0502 | 1282 |  4 | 2 | Yes |  No | [link](ModbusDataStructure.md#firmware-version-register) |
| Serial Number Register     | 0x0504 | 1284 | 16 | 8 | Yes |  No | [link](ModbusDataStructure.md#serial-number-register) |
| Item Number Register       | 0x050C | 1292 | 16 | 8 | Yes |  No | [link](ModbusDataStructure.md#item-number-register) |
| PCB Serial Number Register | 0x0514 | 1300 | 16 | 8 | Yes |  No | [link](ModbusDataStructure.md#pcb-serial-number-register) |

### Gateway Configuration Holding Registers (read / write) FC03 / FC06

| **Register name** | **Register address hex** | **Register address dec** | **Size in bytes** | **Size in words** | **Read** |  **Write** | **Description** |
| ------ | ------ | ------ | ------ | ------ | ------ | ------ | ------ |
| Analog Range Register      | 0x0700 | 1792 |  2 | 1 | Yes | Yes | [link](ModbusDataStructure.md#gateway-analog-range-register) |

&uarr; [back to top](#table-of-contents)

## Rotor Registers

### Rotor Command Registers (coils) FC01/FC05

| **Register name** | **Register address hex** | **Register address dec** | **Size in bytes** | **Size in words** | **Read** |  **Write** | **Description** |
| ------ | ------ | ------ | ------ | ------ | ------ | ------ | ------ |
| Tara Command          | 0x1400 | 5120 | 2 | 1 |      Yes | Yes | [link](ModbusDataStructure.md#rotor-tara-command) |
| Restart Command       | 0x1401 | 5121 | 2 | 1 | always 0 | Yes | [link](ModbusDataStructure.md#rotor-restart-command) |
| Reset Min/Max Command | 0x1402 | 5122 | 2 | 1 | always 0 | Yes | [link](ModbusDataStructure.md#rotor-reset-minmax-command) |

### Rotor Indentification Holding Register (read only) FC03

| **Register name** | **Register address hex** | **Register address dec** | **Size in bytes** | **Size in words** | **Read** |  **Write** | **Description** |
| ------ | ------ | ------ | ------ | ------ | ------ | ------ | ------ |
| Hardware Version Register | 0x1500 | 5376 |  4 | 2 | Yes | No | [link](ModbusDataStructure.md#hardware-version-register) |
| Firmware Version Register | 0x1502 | 5378 |  4 | 2 | Yes | No | [link](ModbusDataStructure.md#firmware-version-register) |
| Serial Number Register    | 0x1504 | 5380 | 16 | 8 | Yes | No | [link](ModbusDataStructure.md#serial-number-register) |
| Item Number Register      | 0x150C | 5388 | 16 | 8 | Yes | No | [link](ModbusDataStructure.md#item-number-register) |

### Rotor Data Holding Register (read only) FC03

| **Register name** | **Register address hex** | **Register address dec** | **Size in bytes** | **Size in words** | **Read** |  **Write** | **Description** |
| ------ | ------ | ------ | ------ | ------ | ------ | ------ | ------ |
| Package Header Register   | 0x1600 | 5632 |  18 |  9 | Yes | No | [link](ModbusDataStructure.md#rotor-package-header-register) |
| Process Data Register     | 0x1609 | 5641 |  18 |  9 | Yes | No | [link](ModbusDataStructure.md#rotor-process-data-register) |
| Payload Array Register    | 0x1612 | 5650 | 100 | 50 | Yes | No | [link](ModbusDataStructure.md#rotor-payload-array-register) |

### Rotor Configuration Holding Registers (read / write) FC03 / FC06

| **Register name** | **Register address hex** | **Register address dec** | **Size in bytes** | **Size in words** | **Read** |  **Write** | **Description** |
| ------ | ------ | ------ | ------ | ------ | ------ | ------ | ------ |
| Filter Selection Register   | 0x1700 | 5888 |  2 | 1 | Yes | Yes | [link](ModbusDataStructure.md#rotor-filter-selection-register) |
| Transmit Rate Register      | 0x1701 | 5889 |  2 | 1 | Yes | Yes | [link](ModbusDataStructure.md#rotor-transmit-rate-register) |

&uarr; [back to top](#table-of-contents)

[Back to main page](../README.md)
