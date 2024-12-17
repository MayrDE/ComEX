# REST-API documentation

## Table of contents

1. [Introduction](#introduction)
1. [Application examples](#application-examples)
1. [OpenAPI YAML file](#openapi-yaml-file)

## Introduction

This section contains different REST-API examples for Bruno API client, cURL and Node-RED applications.

## Important information

All rotor commands, that ***change the rotor configuration***, will only take effect if rotor is ***not*** in `run mode` AND after the rotor has been restarted to load the new configuration.

All rotor commands like `Tara`, `Reset Min/Max` etc. are only temporary, until the next restart of the rotor (or gateway).

## Application examples

- [Bruno Opensource API client example](Bruno/README.md)
- [cURL command line examples](cURL/README.md)
- [Node-RED examples](Node-RED/README.md)

## OpenAPI YAML file

In addition to the examples above, the original OpenAPI YAML file [openapi.yaml](openapi.yaml) is provided next to this readme file in case you want to import the ROBA-drive-checker requests to a different REST-API client.

This file is created according to the [OpenAPI Specification](https://github.com/OAI/OpenAPI-Specification)

If you don't have an editor to open the [openapi.yaml](openapi.yaml) file you can use one of the following options:

- [Swagger online editor](https://editor.swagger.io/) Copy the content of the openapi.yaml and paste it into the swagger editor
- [Swagger online editor NEW](https://editor-next.swagger.io/) Copy the content of the openapi.yaml and paste it into the swagger editor

The swagger editors have great benefits because they can generate source code directly from the yaml file. Check out the editor and look for the `Generate Server` and `Generate Client` menus **after pasting the yaml contents** into the editor.

If you are working with `Visual Studio Code` you should also check out:

- [OpenAPI (Swagger) Editor](https://github.com/42Crunch/vscode-openapi)
- [OpenAPI Linter for VS Code](https://github.com/ringcentral/vscode-openapi-linter)

---

[Back to main page](../README.md)
