# Docker Ducks

## Nombre del proyecto

TeamGitPractice API - TeamGitPractive_DockerDucks

## Descripción breve de la práctica

Práctica colaborativa de Git y GitHub desarrollada por el equipo Docker Ducks. El objetivo fue trabajar con ramas personales, commits desde consola y Visual Studio, pull requests, revisión entre integrantes, resolución de conflictos, uso de `restore`, `restore --staged` y `revert` dentro de un repositorio compartido.

## Integrantes

| Integrante | Nombre completo | Usuario GitHub | Rama personal |
| --- | --- | --- | --- |
| 1 | Juan David Velasquez Murillo | [Juandavm12](https://github.com/Juandavm12) | `juan-velasquez` |
| 2 | Alejandra Madrid Calderon | [alejamc14](https://github.com/alejamc14) | `alejandra-madrid` |
| 3 | Sara Regino Ferrano | [ArsaOniSaturn](https://github.com/ArsaOniSaturn) | `sara-ferraro` |
| 4 | Jose David Vasquez | [jvas04](https://github.com/jvas04) | `jose-vasquez` |
| 5 | Paula Andrea Calderon Quintero | [paucq](https://github.com/paucq) | `paula-calderon` |

## Instrucciones básicas para ejecutar la API

1. Clonar el repositorio:

   ```bash
   git clone https://github.com/Juandavm12/TeamGitPractive_DockerDucks.git
   ```

2. Entrar al proyecto:

   ```bash
   cd TeamGitPractive_DockerDucks
   ```

3. Restaurar dependencias:

   ```bash
   dotnet restore
   ```

4. Ejecutar la API con el perfil HTTP:

   ```bash
   dotnet run --project TeamGitPractice --launch-profile http
   ```

5. Abrir la API en el navegador o probarla con una herramienta como Postman, curl o Bruno:

   ```text
   http://localhost:5007
   ```

> En modo desarrollo, la especificación OpenAPI queda disponible en `/openapi/v1.json`.

## Endpoints desarrollados por el equipo

| Método | Endpoint | Descripción |
| --- | --- | --- |
| GET | `/WeatherForecast` | Endpoint base generado por la plantilla de ASP.NET Core. |
| GET | `/api/status` | Retorna el estado general de la API. |
| GET | `/api/status/team` | Retorna el estado del equipo Docker Ducks. |
| GET | `/api/health` | Retorna información básica de salud del servicio. |
| GET | `/api/health/time` | Retorna la hora UTC del servidor. |
| GET | `/api/info` | Retorna una descripción de la práctica colaborativa. |
| GET | `/api/info/tools` | Retorna las herramientas utilizadas durante la práctica. |
| GET | `/api/version` | Retorna la versión de la API. |
| GET | `/api/version/platform` | Retorna información de plataforma del proyecto. |

## Evidencias

Las evidencias de commits, pull requests, revisión, resolución de conflictos, `restore`, `restore --staged`, `revert` y colaboradores se encuentran en:

- [EVIDENCIAS.md](EVIDENCIAS.md)
