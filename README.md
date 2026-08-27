# 🚚 ExpressCargo - Sistema de Gestión de Flota

> Proyecto académico para la asignatura de Programación .NET.  
> **Evaluación Unidad N°2** – Aplicación de herencia, polimorfismo, interfaces, colecciones, control de flujo y excepciones.

---

## 📖 Descripción

**ExpressCargo** es una aplicación de consola que simula la gestión de una flota de vehículos de reparto. La empresa opera con dos tipos de vehículos:

- **Camiones de Reparto Refrigerados** (`Camion`)
- **Drones Autónomos de Entrega** (`Drone`)

Ambos heredan de una clase base `VehiculoEnvio` y cada uno implementa sus propias reglas de negocio. El programa permite:

- Mostrar la ficha técnica de cada vehículo (datos comunes + específicos).
- Calcular el costo total de envío según el tipo de vehículo.
- Activar el sistema de enfriamiento extremo (solo en camiones que tengan refrigerante certificado).
- Gestionar errores mediante excepciones manuales y bloques `try-catch`.

---

## 🏗️ Estructura del Proyecto

```
Elias_Ortiz_ExpressCargo/
├── Program.cs                 # Punto de entrada, creación de colección y lógica principal
├── VehiculoEnvio.cs           # Clase base (abstracta en concepto, con virtual)
├── Camion.cs                  # Clase hija que implementa IEnfriamiento
├── Drone.cs                   # Clase hija
├── IEnfriamiento.cs           # Interfaz para sistemas de refrigeración
└── Elias_Ortiz_ExpressCargo.csproj
```

---

## ⚙️ Requisitos

- [.NET SDK](https://dotnet.microsoft.com/download) (versión 6.0 o superior)
- Terminal / Consola con soporte para colores (recomendado: Windows Terminal, VS Code, PowerShell)

---

## 🚀 Ejecución

1. Clona el repositorio:
   ```bash
   git clone https://github.com/tu-usuario/Elias_Ortiz_ExpressCargo.git
   ```
2. Navega al directorio del proyecto:
   ```bash
   cd Elias_Ortiz_ExpressCargo
   ```
3. Compila y ejecuta:
   ```bash
   dotnet run
   ```

---

## 🖥️ Salida Esperada

La aplicación mostrará en consola:

- Una ficha por cada vehículo (con colores para etiquetas y valores).
- Alerta si el nivel de combustible es crítico (<15%).
- Intentos de activar el frío extremo en ambos camiones.
- Manejo de errores si el camión no tiene refrigerante.

### Ejemplo de salida (texto coloreado)
```
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

========= TIPO: CAMIÓN ==========
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

...

ERROR: No se puede activar el sistema de frío sin un refrigerante certificado instalado.
Sistema de frío activado. Temperatura estabilizada en -25°C

Proceso finalizado.
```

---

## 🧠 Conceptos Aplicados

| Concepto | Implementación |
|----------|----------------|
| **Herencia** | `Camion` y `Drone` heredan de `VehiculoEnvio` |
| **Polimorfismo** | `override` de `MostrarFichaTecnica()` y `CalcularCostoTotal()` |
| **Interfaz** | `IEnfriamiento` implementada por `Camion` |
| **Colecciones** | `List<VehiculoEnvio>` para almacenar la flota |
| **Control de flujo** | `foreach` e `if-else` para evaluar combustible |
| **Excepciones** | Lanzamiento manual con `throw` y captura con `try-catch` |

---

## 👤 Autor

- **Elias Ortiz**  
  Estudiante de [nombre de la carrera]  
  Repositorio: [https://github.com/tu-usuario/Elias_Ortiz_ExpressCargo](https://github.com/tu-usuario/Elias_Ortiz_ExpressCargo)

---

## 📄 Licencia

Este proyecto es de uso educativo. Puede ser utilizado como referencia para el aprendizaje de C# y Programación Orientada a Objetos.

---

> ¡Gracias por revisar este proyecto! Si tienes sugerencias o preguntas, no dudes en abrir un issue.
