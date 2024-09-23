# ST Solution - Sistema de Gestión de Inventario

**Fecha de creación:** 21/04/2023  
**Autor:** Stiven De La Rosa Brito  
**Materia:** Programación 2  
**Profesor:** Bismark Montero  

## Descripción

**ST Solution** es un sistema de gestión de inventario desarrollado como proyecto final para la asignatura de Programación 2. La aplicación permite gestionar productos, categorías, proveedores y realizar un seguimiento detallado del inventario en tiempo real.

![Captura de Pantalla](https://github.com/codestiven/ST-Solution---Sistema-de-Gesti-n-de-Inventario/blob/master/Captura%20de%20pantalla%20(386).png)

## Tecnologías Utilizadas

- **Lenguaje de programación:** C#
- **Framework:** Windows Forms
- **Base de datos:** SQL Server
- **Diseño de interfaz:** Plantilla de mejora de diseño (con personalización propia)

## Funcionalidades Principales

- **Gestión de Productos:** Permite agregar, editar, eliminar y consultar productos del inventario.
- **Categorías y Proveedores:** Gestión de categorías y proveedores para organizar y facilitar la administración del inventario.
- **Control de Stock:** Seguimiento del nivel de stock de cada producto con alertas para productos con inventario bajo.
- **Búsqueda y Filtrado:** Búsqueda rápida y filtros avanzados para encontrar productos específicos.
- **Reportes:** Generación de reportes de inventario para análisis y toma de decisiones.

## Instalación y Configuración

1. **Clonar el repositorio:**
    ```bash
    git clone https://github.com/tu-usuario/st-solution.git
    ```
2. **Configurar la base de datos:**
   - Crear una base de datos en SQL Server.
   - Importar el archivo `database.sql` incluido en el proyecto para crear las tablas necesarias.

3. **Configurar la cadena de conexión:**
   - En el archivo `App.config`, actualizar la cadena de conexión con los detalles de tu servidor SQL.

4. **Compilar y ejecutar:**
   - Abrir el proyecto en Visual Studio.
   - Compilar la solución y ejecutar la aplicación.

## Requisitos

- **.NET Framework 4.8**
- **SQL Server 2019 o superior**
- **Visual Studio 2019 o superior**

## Créditos

Desarrollado por **Stiven De La Rosa Brito** como proyecto final para la asignatura de Programación 2 impartida por el profesor **Bismark Montero**.

## Licencia

Este proyecto está bajo la Licencia MIT. Consulta el archivo `LICENSE` para más detalles.
