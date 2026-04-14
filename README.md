Aquí tienes el paso a paso detallado para crear el cliente en Visual Studio 2022:

1. Crear el Proyecto Cliente
Abre Visual Studio 2022.

Selecciona Crear un proyecto.

Busca la plantilla Aplicación de consola (.NET Framework).

Nota: Es importante elegir ".NET Framework" y no ".NET Core/6/7/8" para que la compatibilidad con servicios SOAP ASMX sea nativa y sencilla.

Ponle un nombre (ej. BancoCliente) y haz clic en Crear.

2. Vincular el Web Service (El paso clave)
Como estamos usando un servicio .asmx antiguo, no basta con añadir una "Service Reference" común. Sigue esta ruta:

En el Explorador de Soluciones, haz clic derecho sobre el nombre de tu proyecto.

Selecciona Agregar > Referencia de servicio... (Service Reference).

Se abrirá una ventana. No busques el servicio ahí. Haz clic en el botón inferior que dice Enviar... o Avanzado... (Advanced).

En la nueva ventana que aparece, haz clic en el botón inferior que dice Agregar referencia web... (Add Web Reference). Esta es la opción para servicios clásicos.

En el cuadro de URL, pega la dirección donde se está ejecutando tu Web Service (ejemplo: https://localhost:44321/BancoService.asmx).

Haz clic en la flecha verde (Ir). Visual Studio buscará el servicio y mostrará los métodos disponibles (como VerificarSaldoParaCompra).

En Nombre de referencia web, cámbialo a BancoService.

Haz clic en Agregar referencia.
