GESTOR DE ARCHIVOS DE TEXTO MULTIPLATAFORMA (WinForms)
👤 Información del Proyecto
Campo Valor
Nombre(s) del Alumno(s) [SU NOMBRE Y APELLIDO AQUÍ]
Legajo(s) [SU NÚMERO DE LEGAJO AQUÍ]
Asignatura Programación y Estructura de Datos / Programación I
📝 Descripción Breve del Proyecto
Este proyecto es un Sistema de Gestión de Archivos de Texto Multiplataforma desarrollado como
una aplicación de escritorio con Windows Forms en .NET 8.
El objetivo es permitir la manipulación, persistencia y conversión de registros de la clase Alumno en
cuatro formatos de archivo diferentes: TXT, CSV, JSON y XML.
🎯 Funcionalidades Implementadas
La aplicación cubre las 6 funcionalidades requeridas en la consigna:
1. Crear Nuevo Archivo: Permite ingresar datos de alumnos y guardarlos en el formato
seleccionado.
2. Leer Archivo Existente: Visualiza los registros de cualquier formato en una tabla (DataGridView).
3. Modificar Archivo Existente: Carga los registros en memoria para agregar, editar o eliminar
alumnos, con opción de crear un archivo de backup ( .bak ).
4. Eliminar Archivo: Elimina un archivo físicamente tras mostrar sus metadatos (tamaño, fechas) y
solicitar confirmación.
5. Convertir entre Formatos: Permite la conversión bidireccional entre TXT, CSV, JSON y XML sin
pérdida de datos.
6. Crear Reporte con Corte de Control: Genera un reporte agrupado por Apellido, incluyendo
subtotales, resumen general y la opción de guardar el reporte como archivo TXT.
⚙️ Requisitos del Sistema
Para compilar y ejecutar esta aplicación, se necesita:
SDK de .NET: .NET 8 SDK (versión 8.0 o superior).
Entorno de Desarrollo: Visual Studio 2022 (recomendado) o Visual Studio Code con las
extensiones de C#.
Sistema Operativo: Windows 10 / 11 (para ejecutar la aplicación WinForms).
🔨 Instrucciones de Compilación y Ejecución
Siga estos pasos para compilar y ejecutar el proyecto desde la línea de comandos (CLI):
1. Navegar al Directorio: Abra la terminal (CMD, PowerShell o Terminal de VS Code) y navegue
hasta el directorio que contiene el archivo .sln (Solución).
cd ApellidoNombre_GestorAlumnos/
2. Restaurar Dependencias: Asegúrese de que todas las referencias y paquetes necesarios estén
disponibles.
dotnet restore
3. Compilar el Proyecto: Compile la solución en modo de Release (producción) para generar el
ejecutable.
dotnet build --configuration Release
4. Ejecutar la Aplicación: Ejecute el proyecto (la ruta puede variar, verifique la estructura de su
proyecto).
dotnet run
(Alternativamente, si usa Visual Studio, simplemente abra el .sln y presione F5).
📖 Instrucciones de Uso Básico
1. Inicio: El menú principal (Formulario Form1 ) debe mostrar las 6 opciones. Haga clic en la
funcionalidad deseada.
2. Crear Archivo (Opción 1): Ingrese los datos del alumno y haga clic en "Agregar Alumno a la
Lista". Una vez cargados, ingrese el nombre base del archivo y presione "GUARDAR ARCHIVO EN
DISCO".
3. Cargar Archivo (Opción 2, 3, 4, 5, 6): Para cualquier operación que necesite un archivo
existente, ingrese el nombre completo y la extensión del archivo (ej: ejemplo.csv ) en el
campo correspondiente antes de presionar "Cargar/Buscar".
4. Reporte (Opción 6): Cargue un archivo con suficientes datos (se recomienda usar datos con
apellidos repetidos para validar el Corte de Control). El reporte aparecerá en el cuadro de texto
para su visualización y podrá guardarse como TXT.
⚠️ Problemas Conocidos
Ruta de Archivos: La aplicación asume que los archivos se crean y leen desde el directorio de
ejecución ( Environment.CurrentDirectory ). Asegúrese de que los archivos de ejemplo estén
en la misma carpeta que el ejecutable.
Validación Avanzada: La validación de unicidad de Legajo solo se realiza en las funcionalidades
de "Crear" y "Agregar en Modificar" sobre los datos en memoria. La aplicación no valida la
unicidad contra archivos ya existentes en disco.
Encoding: Todos los archivos se leen y escriben utilizando codificación UTF-8.
✨ Extras Implementados
Interfaz Gráfica de Usuario (GUI): Migración de la interfaz original de consola a una aplicación
de escritorio WinForms para una interacción de usuario más clara y amigable (cumpliendo con el
criterio de Calificación Destacada).
Manejo de Metadatos: La funcionalidad de Eliminar (Opción 4) utiliza la clase FileInfo para
mostrar metadatos del archivo antes de la eliminación.
Validaciones Robustas: Uso de expresiones regulares ( Regex ) para validar Legajo, Documento,
Teléfono (numéricos) y formato de Email en los formularios de entrada de datos.