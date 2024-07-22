# Xbox Game Pass API SOAP 🎮

## Descripción 📄

Esta API REST inspirada en el servicio de Xbox Game Pass permite gestionar información relacionada con este servicio. Proporciona operaciones CRUD (Crear, Leer, Actualizar, Eliminar) y utiliza procedimientos almacenados para interactuar con la base de datos. La API está diseñada para facilitar la gestión de clientes, planes, suscripciones y pagos dentro del ecosistema de Xbox Game Pass o cualquier otro tipo de servicio relacionado con este modelo de negocio, ya que el concepto es el mismo.

## Características ✨

- **Clientes**: CRUD de clientes suscritos al servicio.
- **Planes**: CRUD de planes disponibles en Xbox Game Pass.
- **Suscripciones**: CRUD de suscripciones de clientes a los planes de Xbox Game Pass.
- **Pagos**: CRUD de pagos realizados por los clientes.
- **Procedimientos Almacenados**: Uso de procedimientos almacenados para tomar decisiones y mostrar gráficos estadísticos en función de la DATA.

## Endpoints 🚀

### Clientes 👤

- **WSDL**
  - `URL/API_ClientesXbox.asmx?WSDL`
- **Uso del CRUD**
  - `URL/API_ClientesXbox.asmx/{operación}`

### Planes 📅

- **WSDL**
  - `URL/API_PlanesXbox.asmx?WSDL`
- **Uso del CRUD**
  - `URL/API_PlanesXbox.asmx/{operación}`

### Suscripciones 📃

- **WSDL**
  - `URL/API_SuscripcionesXbox.asmx?WSDL`
- **Uso del CRUD**
  - `URL/API_SuscripcionesXbox.asmx/{operación}`

### Pagos 💳

- **WSDL**
  - `URL/API_PagosXbox.asmx?WSDL`
- **Uso del CRUD**
  - `URL/API_PagosXbox.asmx/{operación}`

## Lista de Operaciones (Nombres) 🗄️

- **Clientes, Planes, Suscripciones y Pagos:**
  - `Actualizar`
  - `Eliminar`
  - `Insertar`
  - `Listar`
  - `buscarPorId`
  
- **Pagos:**
  - `buscarPorCodigo`

---


