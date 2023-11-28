using App3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace App3
{
    public partial class Page1 : ContentPage
    {
        public Page1(Formulario datos)
        {
            InitializeComponent();

            // Llena la información en Page1 con los datos del formulario
            // Aquí debes acceder a las propiedades de la clase Formulario y asignarlas a los controles de la página
            // Ejemplo:

            nombreApellidosLabel.Text = "Nombre y Apellidos: " + datos.NombreApellidos;
            fechaNacimientoLabel.Text = "Fecha de Nacimiento: " + datos.FechaNacimiento.ToString("d");
            ocupacionLabel.Text = "Ocupación: " + datos.Ocupacion;
            contactoLabel.Text = "Contacto: " + datos.Contacto;
            nacionalidadLabel.Text = "Nacionalidad: " + datos.Nacionalidad;
            educacionLabel.Text = "Nivel de Educación: " + datos.Educacion;
            idiomasLabel.Text = "Idiomas: " + (datos.Ingles ? "Inglés " : "") + (datos.Indonesio ? "Indonesio" : "");
            lenguajesProgramacionLabel.Text = "Lenguajes de Programación: " + datos.LenguajeProgramacion;
            aptitudesLabel.Text = "Aptitudes: " + datos.Aptitudes;
            habilidadesLabel.Text = "Habilidades: " + (datos.Liderazgo ? "Liderazgo " : "") + (datos.ProgramacionCpp ? "Programación C++" : "");
            perfilLabel.Text = "Experiencia Laboral: " + datos.ExperienciaLaboral;
        }
    }
}
