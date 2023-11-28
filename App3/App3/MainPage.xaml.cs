using System;
using Xamarin.Forms;

namespace App3
{
    public partial class MainPage : ContentPage
    {
        private Entry nombreApellidosEntry;
        private DatePicker fechaNacimientoPicker;
        private Entry ocupacionEntry;
        private Entry contactoEntry;
        private Picker nacionalidadPicker;
        private Picker educacionPicker;
        private Switch inglesSwitch;
        private Switch indonesioSwitch;
        private Picker lenguajesProgramacionPicker;
        private Entry aptitudesEntry;
        private Switch liderazgoSwitch;
        private Switch programacionCppSwitch;
        private Editor perfilEditor;

        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
         

            // Crear controles
            nombreApellidosEntry = new Entry { Placeholder = "Ingrese su nombre y apellidos" };
            fechaNacimientoPicker = new DatePicker();
            ocupacionEntry = new Entry { Placeholder = "Ingrese su ocupación" };
            contactoEntry = new Entry { Placeholder = "Ingrese su contacto" };
            nacionalidadPicker = new Picker();
            educacionPicker = new Picker();
            inglesSwitch = new Switch { IsToggled = false };
            indonesioSwitch = new Switch { IsToggled = false };
            lenguajesProgramacionPicker = new Picker();
            aptitudesEntry = new Entry { Placeholder = "Ingrese sus aptitudes" };
            liderazgoSwitch = new Switch { IsToggled = false };
            programacionCppSwitch = new Switch { IsToggled = false };
            perfilEditor = new Editor { Placeholder = "Ingrese su experiencia laboral", HeightRequest = 100 };

            // Agregar opciones a los Pickers
            nacionalidadPicker.Items.Add("Perú");
            nacionalidadPicker.Items.Add("Argentina");
            // Agrega el resto de los países

            educacionPicker.Items.Add("Educación Preescolar");
            educacionPicker.Items.Add("Educación Primaria");
            // Agrega el resto de las opciones

            lenguajesProgramacionPicker.Items.Add("Java");
            lenguajesProgramacionPicker.Items.Add("Python");
            // Agrega el resto de las opciones

            // Crear botón de enviar
            var enviarButton = new Button { Text = "Enviar" };
            enviarButton.Clicked += EnviarButton_Clicked;

            // Organizar la interfaz de usuario en un diseño
            var stackLayout = new StackLayout
            {
                Padding = new Thickness(20),
                Spacing = 10,
                Children =
                {
                    new Label { Text = "Nombre y Apellidos:" },
                    nombreApellidosEntry,
                    new Label { Text = "Fecha de Nacimiento:" },
                    fechaNacimientoPicker,
                    new Label { Text = "Ocupación:" },
                    ocupacionEntry,
                    new Label { Text = "Contacto (teléfono, email):" },
                    contactoEntry,
                    new Label { Text = "Nacionalidad:" },
                    nacionalidadPicker,
                    new Label { Text = "Nivel de Educación:" },
                    educacionPicker,
                    new Label { Text = "Idiomas:" },
                    inglesSwitch,
                    indonesioSwitch,
                    new Label { Text = "Lenguajes de Programación:" },
                    lenguajesProgramacionPicker,
                    new Label { Text = "Aptitudes:" },
                    aptitudesEntry,
                    new Label { Text = "Habilidades:" },
                    liderazgoSwitch,
                    programacionCppSwitch,
                    new Label { Text = "Experiencia Laboral:" },
                    perfilEditor,
                    enviarButton
                }
            };

            // Envolver el StackLayout en un ScrollView para habilitar el desplazamiento
            var scrollView = new ScrollView
            {
                Content = stackLayout
            };

            // Establecer el diseño como contenido de la página
            Content = scrollView;
        }

        private async void EnviarButton_Clicked(object sender, EventArgs e)
        {
            try
            {
                // Obtén los valores de los controles en la página actual (MainPage)
                var nombreApellidos = nombreApellidosEntry.Text;
                var fechaNacimiento = fechaNacimientoPicker.Date;
                var ocupacion = ocupacionEntry.Text;
                var contacto = contactoEntry.Text;
                var nacionalidad = nacionalidadPicker.SelectedItem?.ToString();
                var educacion = educacionPicker.SelectedItem?.ToString();
                var ingles = inglesSwitch.IsToggled;
                var indonesio = indonesioSwitch.IsToggled;
                var lenguajeProgramacion = lenguajesProgramacionPicker.SelectedItem?.ToString();
                var aptitudes = aptitudesEntry.Text;
                var liderazgo = liderazgoSwitch.IsToggled;
                var programacionCpp = programacionCppSwitch.IsToggled;
                var experienciaLaboral = perfilEditor.Text;

                // Crear una instancia de la clase que contiene los datos del formulario
                var datosFormulario = new Formulario
                {
                    NombreApellidos = nombreApellidos,
                    FechaNacimiento = fechaNacimiento,
                    Ocupacion = ocupacion,
                    Contacto = contacto,
                    Nacionalidad = nacionalidad,
                    Educacion = educacion,
                    Ingles = ingles,
                    Indonesio = indonesio,
                    LenguajeProgramacion = lenguajeProgramacion,
                    Aptitudes = aptitudes,
                    Liderazgo = liderazgo,
                    ProgramacionCpp = programacionCpp,
                    ExperienciaLaboral = experienciaLaboral
                    // Agrega el resto de las propiedades según sea necesario
                };

                // Crea la página de curriculum y pasa los datos del formulario
                var curriculumPage = new Page1(datosFormulario);

                // Navega a la página de curriculum
                await Navigation.PushAsync(curriculumPage);
            }
            catch (Exception ex)
            {
                // Maneja cualquier excepción que pueda ocurrir durante el procesamiento del formulario
                Console.WriteLine($"Error al procesar el formulario: {ex.Message}");
                // También puedes mostrar un mensaje al usuario, por ejemplo:
                // await DisplayAlert("Error", "Hubo un error al procesar el formulario", "OK");
            }
        }
    }
}
