using System.Linq;
using System.Windows;
using WpfAppPersonas.Models; //  Esto importa el modelo

namespace WpfAppPersonas
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CargarPersonas(); //Carga los datos al abrir
        }

        private void CargarPersonas()
        {
            using (var context = new PersonasDBEntities())
            {
                var personas = context.Personas.ToList();
                PersonasDataGrid.ItemsSource = personas;
            }
        }
    }
}
