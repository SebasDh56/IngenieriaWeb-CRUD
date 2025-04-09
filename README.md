IngenieriaWeb1

Gestión de Autos con ASP.NET Core

Bienvenido a IngenieriaWeb1, una aplicación web desarrollada con ASP.NET Core que permite gestionar información de vehículos de manera sencilla y eficiente. Este proyecto incluye un CRUD (Create, Read, Update, Delete) para autos, con un diseño moderno y atractivo basado en Bootstrap y Font Awesome.

Tabla de Contenidos

Descripción
Características
Requisitos
Instalación
Uso
Estructura del Proyecto
Contribución
Licencia
Descripción
IngenieriaWeb1 es una aplicación web diseñada para registrar y administrar información de autos, incluyendo placa, marca, modelo, propietario y año. La interfaz es intuitiva y visualmente atractiva, con soporte para validaciones de datos y una navegación fluida.

Características

CRUD Completo: Crear, leer, actualizar y eliminar registros de autos.
Diseño Responsivo: Adaptado a dispositivos móviles y de escritorio gracias a Bootstrap.
Interfaz Atractiva: Uso de íconos (Font Awesome), colores y efectos hover para mejorar la experiencia del usuario.
Validación de Datos: Reglas definidas en el modelo para garantizar la integridad de la información.
Navegación Intuitiva: Barra de navegación con enlaces claros a las secciones principales.
Requisitos

.NET Core SDK 6.0 o superior (https://dotnet.microsoft.com/download)
Visual Studio 2022 (https://visualstudio.microsoft.com/) (o cualquier IDE compatible con C#)
Conexión a internet (para cargar Font Awesome desde CDN, opcional si se usa localmente)
Base de datos (opcional, si usas Entity Framework; por ejemplo, SQL Server)
Instalación
Sigue estos pasos para configurar el proyecto en tu máquina local:

Clonar el Repositorio git clone https://github.com/tu-usuario/IngenieriaWeb1.git cd IngenieriaWeb1
Restaurar Dependencias Abre el proyecto en Visual Studio o ejecuta: dotnet restore
Configurar la Base de Datos (Opcional)
Si usas Entity Framework, edita appsettings.json con tu cadena de conexión: "ConnectionStrings": { "DefaultConnection": "Server=(localdb)\mssqllocaldb;Database=IngenieriaWeb1;Trusted_Connection=True;" }
Aplica las migraciones: dotnet ef migrations add InitialCreate dotnet ef database update
Ejecutar la Aplicación dotnet run O abre el proyecto en Visual Studio y presiona F5.
Acceder a la Aplicación Abre tu navegador en: https://localhost:5001 (o el puerto configurado).
Uso

Página de Inicio:
Visita la página principal para una bienvenida y un enlace rápido a la lista de autos.
Gestión de Autos:
Haz clic en "Autos" en la barra de navegación.
Usa "Crear Nuevo" para agregar un auto.
Edita, elimina o ve detalles de los autos existentes desde la lista.
Validaciones:
Los campos como Placa, Marca, Modelo, Propietario y Año son obligatorios y tienen restricciones (longitud y rango).
Estructura del Proyecto
IngenieriaWeb1/
├── Controllers/
│   └── AutosController.cs       # Controlador para CRUD de autos
│   └── HomeController.cs        # Controlador para páginas básicas
├── Models/
│   └── Autos.cs                 # Modelo de datos para autos
├── Views/
│   ├── Autos/
│   │   ├── Create.cshtml        # Vista para crear autos
│   │   ├── Delete.cshtml        # Vista para eliminar autos
│   │   ├── Details.cshtml       # Vista para detalles de autos
│   │   ├── Edit.cshtml          # Vista para editar autos
│   │   └── Index.cshtml         # Lista de autos
│   ├── Home/
│   │   ├── Index.cshtml         # Página de inicio
│   │   └── Privacy.cshtml       # Página de privacidad
│   └── Shared/
│       └── _Layout.cshtml       # Plantilla principal
├── wwwroot/
│   ├── css/
│   │   └── site.css            # Estilos personalizados
│   └── lib/
│       ├── bootstrap/           # Bootstrap CSS y JS
│       └── jquery/              # jQuery
├── appsettings.json             # Configuración de la aplicación
└── Program.cs                   # Punto de entrada
