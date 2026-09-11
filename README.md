# Desarrollo de una Web API en ASP.NET Core

La empresa necesita una Web API para gestionar solicitudes de préstamos. La API debe interactuar con una base de datos usando Entity Framework y proporcionar documentación a través de Swagger. Los actores involucrados son el 'originador de créditos' que envía las solicitudes y el'motor de evaluación' que las procesa. La API debe manejar un mínimo de 1 500 solicitudes por segundo en hora pico y garantizar idempotencia en el registro de solicitudes por número de operación + canal.

## Informacion General

| Campo | Valor |
|-------|-------|
| **Tema** | aspnetcore-webapi |
| **Nivel** | junior-l1 |
| **Tipo** | practical |
| **Tiempo estimado** | 8 horas |

## Fases del Reto

### Fase 0: Configuración del Proyecto

**Objetivo:** Obtener el proyecto base funcional enviando el Código Base a un asistente de IA, que lo analizará, corregirá errores y generará un ZIP listo para usar.

**Tiempo estimado:** 15-30 minutos

**Instrucciones:**

- Asegúrate de tener instalado para ejecutar el proyecto: Un IDE o editor de código.
- Copia todo el contenido del campo **Código Base** de este reto — incluyendo el texto de instrucciones que aparece al inicio.
- Abre un asistente de IA (Claude en claude.ai, ChatGPT o Gemini — se recomienda Claude), pega el contenido copiado en el chat y envíalo.
- El asistente analizará los archivos, corregirá errores y generará un archivo ZIP descargable. Descárgalo y extráelo en la carpeta donde quieras trabajar.
- Verifica que el proyecto arranca sin errores.

**Entregable:** El proyecto compila/arranca sin errores.

<details>
<summary>Pistas de conocimiento</summary>

- Copia el Código Base completo incluyendo el texto de instrucciones al inicio — esas instrucciones le indican al asistente exactamente qué hacer con los archivos.
- Si el asistente no genera el ZIP automáticamente al terminar el análisis, escríbele: "genera el ZIP ahora".
- Si el proyecto tiene errores al arrancar, comparte el mensaje de error con el mismo asistente para que lo corrija.

</details>

### Fase 1: Configuración inicial y primera ruta

**Objetivo:** Configurar el proyecto y crear una ruta básica para aceptar solicitudes de préstamos.

**Tiempo estimado:** 2 horas

**Instrucciones:**

- Configurar el proyecto ASP.NET Core.
- Crear una ruta que acepte solicitudes de préstamos con los campos requeridos (número de operación, monto, plazo, canal).
- Garantizar que la solicitud se registra con idempotencia por número de operación + canal.

**Entregable:** Proyecto ASP.NET Core con una ruta operativa que acepta y registra solicitudes de préstamos con idempotencia.

<details>
<summary>Pistas de conocimiento</summary>

- Considera cómo manejar la persistencia de datos y la idempotencia.
- Piensa en cómo validar los campos de entrada.

</details>

### Fase 2: Integración con base de datos y Swagger

**Objetivo:** Integrar la API con una base de datos usando Entity Framework y configurar Swagger para documentación.

**Tiempo estimado:** 3 horas

**Instrucciones:**

- Configurar Entity Framework para interactuar con la base de datos.
- Crear modelos y contexto para las solicitudes de préstamos.
- Configurar Swagger para documentar la API.

**Entregable:** API integrada con base de datos y documentada con Swagger.

<details>
<summary>Pistas de conocimiento</summary>

- Considera cómo mapear los modelos a la base de datos.
- Piensa en cómo configurar Swagger para que sea útil para los usuarios de la API.

</details>

### Fase 3: Manejo de errores y validaciones

**Objetivo:** Implementar manejo de errores y validaciones en la API.

**Tiempo estimado:** 2 horas

**Instrucciones:**

- Implementar validaciones para los campos de entrada.
- Manejar errores comunes como solicitudes duplicadas o falta de campos requeridos.
- Garantizar que la API devuelva respuestas adecuadas en caso de error.

**Entregable:** API con validaciones y manejo de errores implementados.

<details>
<summary>Pistas de conocimiento</summary>

- Considera cómo validar los campos de entrada de forma eficiente.
- Piensa en cómo manejar errores de forma que el usuario reciba información útil.

</details>

### Fase 4: Optimización y pruebas

**Objetivo:** Optimizar la API para manejar el throughput requerido y realizar pruebas.

**Tiempo estimado:** 1 hora

**Instrucciones:**

- Optimizar la API para manejar un mínimo de 1 500 solicitudes por segundo en hora pico.
- Realizar pruebas de carga y funcionales para asegurar que la API cumple con los requisitos.
- Documentar los resultados de las pruebas y cualquier optimización realizada.

**Entregable:** API optimizada y documentada con resultados de pruebas.

<details>
<summary>Pistas de conocimiento</summary>

- Considera cómo optimizar la API para manejar el throughput requerido.
- Piensa en cómo realizar pruebas de carga y funcionales de forma efectiva.

</details>

## Dimensiones Evaluadas

- **queEs**: ¿Qué es una Web API y cuál es su propósito en este contexto?
- **paraQueSirve**: ¿Para qué sirve la integración con Entity Framework en este proyecto?
- **comoSeUsa**: ¿Cómo se usa Swagger para documentar una API?
- **erroresComunes**: ¿Cuáles son los errores comunes que pueden ocurrir al manejar solicitudes de préstamos y cómo se pueden evitar?
- **queDecisionesImplica**: ¿Qué decisiones implica la optimización de la API para manejar un alto throughput?

## Criterios de Evaluacion

- Configuración correcta del proyecto ASP.NET Core.
- Creación de una ruta operativa que acepta y registra solicitudes de préstamos con idempotencia.
- Integración exitosa con base de datos usando Entity Framework.
- Configuración adecuada de Swagger para documentar la API.
- Implementación de validaciones y manejo de errores efectivos.
- Optimización de la API para manejar el throughput requerido.
- Realización y documentación de pruebas de carga y funcionales.

## Como trabajar con un asistente de IA

- **AGENTS.md** — instrucciones nativas del repo (Cursor, Codex, Copilot, Gemini, Claude Code). Abrí el proyecto y el agente las carga solo.
- **PROMPT_MEJORA.md** — el mismo prompt, para copiar y pegar en un chat (claude.ai, ChatGPT, etc.).

---

*Reto generado automaticamente por Challenge Generator - Pragma*
