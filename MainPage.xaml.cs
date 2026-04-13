using System.Collections.ObjectModel;

namespace QuickNotesApp;

public partial class MainPage : ContentPage
{
    // Esta lista guarda las notas en la memoria del cel
    public ObservableCollection<string> Notas { get; set; } = new ObservableCollection<string>();

    public MainPage()
    {
        InitializeComponent();
        // Conectamos la lista con el diseño
        ListaNotas.ItemsSource = Notas;
    }

    private void OnGuardarClicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(NotaEditor.Text))
        {
            // Agregamos la nota al principio de la lista
            Notas.Insert(0, $"📌 {NotaEditor.Text}");

            // Limpiamos el editor para la siguiente nota
            NotaEditor.Text = string.Empty;
        }
    }
}