# Pang Game - Clone / WIP
this is a clone from scratch



@Author: Victor Bolinches

@Author: vicboma1


## Manuales

### Dispositivos 
* [Biometríca facial y mano](http://gitlab-val.es.capgemini.com/gitlab/mercadona_pos/Manuales#biometríca-facial-y-mano)
* [Lector de llave](http://gitlab-val.es.capgemini.com/gitlab/mercadona_pos/Manuales#lector-de-llave)
* [Lector NFC](http://gitlab-val.es.capgemini.com/gitlab/mercadona_pos/Manuales#lector-NFC)
* [Lector de huella](http://gitlab-val.es.capgemini.com/gitlab/mercadona_pos/Manuales#lector-de-huella)

# Dispositivos

## Biometríca facial y mano

* Sistema Operativo : Windows 
* Drivers : [intel_rs_sdk_offline_package_10.0.26.0396.exe](http://registrationcenter-download.intel.com/akdlm/irc_nas/vcp/9078/intel_rs_sdk_offline_package_10.0.26.0396.exe)  | 1,79 GB (1.926.286.992 bytes) - Registro necesario
* Librerias : libpxccpp2c.dll y libpxcclrcs.dll
* Hardware : Intel RealSense SR300
* Software :[Visual Studio 2015 - 2017
* Descripción : 
    1 - Instalar los drivers
    2 - Conectar el dispositivo Hardware
    3 - Abrir la solución del proyecto en Visual Studio
    4 - Ejecutar la aplicación

## Lector de llave

* Sistema Operativo : Linux Red Hat 7.3 
* Drivers : [wn-probase-pos-2.4.5-x86_64.rpm]()  | 18,4 MB (19.345.408 bytes)
* Hardware : BA9x_iButton USB 
* Descripción : 
    1 - Ejecutar "wn-probase-pos-2.4.5-x86_64.rpm" con el comando : rpm -ivh wn-probase-pos-2.4.5-x86_64.rpm
    2 - Conectar el dispositivo iButton USB
    3 - Ejecutar el comando : lsush
    4 - Visualizar que el dispositivo esté conectado
    5 - Ir a la ruta /opt/wn/javapos/

    
## Lector NFC
```

```

## Lector huella
```

```
