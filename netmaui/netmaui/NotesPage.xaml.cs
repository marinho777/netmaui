namespace netmaui;

public partial class NotesPage : ContentPage
{

    String path = Path.Combine(FileSystem.AppDataDirectory, "note.txt");
    String content = "";
	public NotesPage()
	{
		InitializeComponent();

        //ler o arquivo
	}

    private void Button_Clicked_Save(object sender, EventArgs e)
    {
        content = EditorNotes.Text;
        File.WriteAllText(path, content);
    }
    private void Button_Clicked_Delete(object sender, EventArgs e)
    {

    }
}