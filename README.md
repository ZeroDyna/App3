# App3
## Resumen de los Pasos de Vinculación entre Curriculum y Formulario

### 1. **Implementacion formulario y curriculum:**
   - Se implemento las clases de los trabajos anteriores en xamarin, pero por complicaciones con el curriculum se opto por modificarlo para haceerlo mas simple.

### 2. **Diseño de la Interfaz de Usuario (Formulario):**
   - Implementación de controles en Xamarin.Forms para capturar datos del usuario.
   - Creación de una página (`MainPage`) con controles de entrada y un botón para enviar el formulario.
   - Se Añadio el boton y la capacida de poder deslizar la pantalla hacia abajo.

### 3. **Lógica de Procesamiento (Formulario):**
   - Implementación de un método (`EnviarButton_Clicked`) para procesar y almacenar los datos del formulario en una instancia de la clase `Formulario`.
   - Manejo de excepciones para posibles errores durante el procesamiento del formulario.

### 4. **Creación de la Página de Confirmación:**
   - Desarrollo de una segunda página (`Page1`) para mostrar los datos del formulario.
   - Uso de `Navigation.PushAsync` para navegar desde la página principal a la de confirmación.

### 5. **Creación de la Clase Curriculum:**
   - Creación de una nueva clase `Formulario` con propiedades para almacenar información del usuario.

### 6. **Vinculación entre Curriculum y Formulario:**
   - Modificación de la clase `Page1` para aceptar un objeto `Formulario` como parámetro y mostrar sus datos.
   - Ajuste de la lógica para procesar e inicializar una instancia de la clase `Curriculum` utilizando los datos del formulario.

### 7. **Navegación entre Páginas:**
   - Utilización de la navegación con Xamarin.Forms para pasar de la página de formulario (`MainPage`) a la página de confirmación (`Page1`).

