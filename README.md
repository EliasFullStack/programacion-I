# 🚚 ExpressCargo - Sistema de Gestión de Flota

> Proyecto académico para la asignatura de Programación I.
> **Evaluación Unidad N°2** – Aplicación de herencia, polimorfismo, interfaces, colecciones, control de flujo y excepciones.

---

## 📖 Descripción

**ExpressCargo** es una aplicación de consola desarrollada en **C#** que simula la gestión de una flota de vehículos de reparto.

La empresa opera con dos tipos de vehículos:

* 🚚 **Camiones de Reparto Refrigerados** (`Camion`)
* 🚁 **Drones Autónomos de Entrega** (`Drone`)

Ambos heredan de una clase base `VehiculoEnvio` y cada uno implementa sus propias reglas de negocio.

El programa permite:

* Mostrar la ficha técnica de cada vehículo.
* Calcular el costo total de envío según el tipo de vehículo.
* Evaluar el nivel de combustible.
* Activar el sistema de enfriamiento extremo en camiones que tengan refrigerante certificado.
* Gestionar errores mediante excepciones.
* Utilizar `try-catch` para controlar errores durante la ejecución.
* Administrar la flota mediante una colección `List<VehiculoEnvio>`.

---

## 🏗️ Estructura del Proyecto

```text
Elias_Ortiz_ExpressCargo/
├── Program.cs
├── VehiculoEnvio.cs
├── Camion.cs
├── Drone.cs
├── IEnfriamiento.cs
└── Elias_Ortiz_ExpressCargo.csproj
```

### 📂 Descripción de los archivos

| Archivo            | Descripción                                                                           |
| ------------------ | ------------------------------------------------------------------------------------- |
| `Program.cs`       | Punto de entrada de la aplicación, creación de la colección y lógica principal.       |
| `VehiculoEnvio.cs` | Clase base para los diferentes tipos de vehículos.                                    |
| `Camion.cs`        | Clase derivada que representa los camiones refrigerados e implementa `IEnfriamiento`. |
| `Drone.cs`         | Clase derivada que representa los drones autónomos.                                   |
| `IEnfriamiento.cs` | Interfaz que define el comportamiento del sistema de enfriamiento.                    |
| `.csproj`          | Archivo de configuración del proyecto .NET.                                           |

---

## ⚙️ Tecnologías utilizadas

* **C#**
* **.NET 11.0**
* Programación Orientada a Objetos (POO)
* Herencia
* Polimorfismo
* Interfaces
* Colecciones genéricas
* Control de flujo
* Manejo de excepciones
* Aplicación de consola

---

## ⚙️ Requisitos

Para ejecutar el proyecto necesitas:

* [.NET SDK](https://dotnet.microsoft.com/download), versión **6.0 o superior**.
* Terminal o consola compatible.
* Windows Terminal, PowerShell o la terminal integrada de Visual Studio Code.

Puedes comprobar la versión instalada con:

```bash
dotnet --version
```

---

## 🚀 Ejecución

### 1. Clonar el repositorio

```bash
git clone https://github.com/EliasFullStack/programacion-I.git
```

### 2. Acceder al directorio

```bash
cd programacion-I
```

### 3. Ejecutar el proyecto

```bash
dotnet run
```

### 4. Compilar el proyecto

También puedes comprobar que el proyecto compile correctamente mediante:

```bash
dotnet build
```

---

## 🖥️ Funcionamiento

Al iniciar el programa, se crea una colección de vehículos utilizando:

```csharp
List<VehiculoEnvio>
```

Dentro de esta colección se almacenan diferentes objetos, como:

* Camiones.
* Drones.

Posteriormente, mediante **polimorfismo**, cada objeto ejecuta su propia implementación de:

```csharp
MostrarFichaTecnica()
```

y:

```csharp
CalcularCostoTotal()
```

De esta manera, el programa puede trabajar con diferentes tipos de vehículos utilizando una referencia común de tipo `VehiculoEnvio`.

---

## 📋 Salida Esperada

La aplicación mostrará en consola una ficha técnica para cada vehículo, incluyendo información común y específica.

También se mostrará una alerta cuando el nivel de combustible sea crítico.

Ejemplo:

```text
========= TIPO: DRONE ==========
===== FICHA TÉCNICA =====
Patente               : DR-001
Capacidad de carga    : 4,5 kg
Nivel de combustible  : 90%
Costo base de envío   : $3.000
Número de motores     : 4
Costo total envío     : $5.250
=========================
✅ Energía: Autonomía segura

========= TIPO: CAMIÓN =========
===== FICHA TÉCNICA =====
Patente               : CAM-001
Capacidad de carga    : 1.200 kg
Nivel de combustible  : 10%
Costo base de envío   : $25.000
Temperatura cámara frío : 5°C
Tipo refrigerante     : No asignado
Costo total envío     : $1.825.000
=========================
⚠️ ALERTA: Combustible crítico. Detener ruta

ERROR: No se puede activar el sistema de frío sin un refrigerante certificado instalado.

Sistema de frío activado. Temperatura estabilizada en -25°C

Proceso finalizado.
```

---

## 🧠 Conceptos de Programación Aplicados

| Concepto              | Implementación                                                                         |
| --------------------- | -------------------------------------------------------------------------------------- |
| **Herencia**          | `Camion` y `Drone` heredan de `VehiculoEnvio`.                                         |
| **Polimorfismo**      | Sobrescritura de `MostrarFichaTecnica()` y `CalcularCostoTotal()` mediante `override`. |
| **Interfaz**          | `IEnfriamiento` es implementada por `Camion`.                                          |
| **Colecciones**       | Uso de `List<VehiculoEnvio>` para almacenar la flota.                                  |
| **Control de flujo**  | Uso de `foreach`, `if` y `else` para procesar los vehículos y evaluar condiciones.     |
| **Excepciones**       | Uso de `throw` para generar errores controlados.                                       |
| **Manejo de errores** | Uso de bloques `try-catch` para capturar excepciones.                                  |
| **Encapsulamiento**   | Uso de propiedades para controlar los datos de los vehículos.                          |
| **Métodos virtuales** | Definición de comportamientos que pueden ser modificados por las clases derivadas.     |

---

## 🔄 Arquitectura de clases

La estructura principal del sistema se basa en una relación de herencia:

```text
                VehiculoEnvio
                     │
            ┌────────┴────────┐
            │                 │
         Camion             Drone
            │
            │ implements
            ▼
      IEnfriamiento
```

`VehiculoEnvio` contiene las características y comportamientos comunes de los vehículos.

`Camion` y `Drone` extienden esta funcionalidad implementando sus propias reglas de negocio.

---

## ❄️ Sistema de Enfriamiento

Los camiones refrigerados implementan la interfaz:

```csharp
IEnfriamiento
```

Esta interfaz permite definir el comportamiento necesario para activar el sistema de refrigeración.

El sistema verifica que exista un **refrigerante certificado** antes de permitir la activación del enfriamiento extremo.

Si no existe un refrigerante válido, se genera una excepción mediante:

```csharp
throw
```

La excepción posteriormente es controlada mediante:

```csharp
try-catch
```

Esto permite evitar que un error de negocio termine inesperadamente la ejecución del programa.

---

## ⛽ Control del Combustible

El programa también evalúa el nivel de combustible de cada vehículo.

Cuando el nivel de combustible es inferior al **15%**, se muestra una alerta:

```text
⚠️ ALERTA: Combustible crítico. Detener ruta
```

En caso contrario, el sistema informa que el vehículo posee una autonomía segura.

---

## 🎯 Objetivos de la Evaluación

Este proyecto busca demostrar la aplicación práctica de los principales conceptos de **Programación Orientada a Objetos**:

1. Crear clases y objetos.
2. Utilizar herencia.
3. Aplicar polimorfismo.
4. Implementar interfaces.
5. Trabajar con colecciones.
6. Utilizar estructuras de control.
7. Implementar manejo de excepciones.
8. Aplicar reglas de negocio mediante métodos.
9. Organizar un proyecto utilizando múltiples clases.

---

## 📚 Contexto Académico

**Asignatura:** Programación .NET
**Evaluación:** Unidad N°2
**Lenguaje:** C#
**Plataforma:** .NET
**Tipo de aplicación:** Consola

---

## 👤 Autor

**Elias Ortiz**

Estudiante de Técnico en Informática.

### 🔗 Repositorio

[GitHub — EliasFullStack/programacion-I](https://github.com/EliasFullStack/programacion-I?utm_source=chatgpt.com)

---

## 📄 Licencia

Este proyecto es de uso **educativo y académico**.

Puede ser utilizado como referencia para el aprendizaje de **C#**, **.NET** y **Programación Orientada a Objetos**.

---

## 🙌 Agradecimientos

Gracias por revisar este proyecto académico.

El objetivo de **ExpressCargo** es demostrar de manera práctica la utilización de conceptos fundamentales de la Programación Orientada a Objetos mediante una aplicación de consola desarrollada en C#.

---

**ExpressCargo 🚚 — Sistema de Gestión de Flota**
