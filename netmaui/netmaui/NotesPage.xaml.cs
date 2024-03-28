using Windows.Storage.Pickers.Provider;

namespace netmaui;

public partial class NotesPage : ContentPage
{
    String path = Path.Combine(FileSystem.AppDataDirectory, "note.txt");
    String content = "";
	public NotesPage()
	{
        InitializeComponent();
        if (File.Exists(path))
        {
            TextEditor.Text = File.ReadAllText(path);
     
        }
    }

    private void Button_Clicked_Save(object sender, EventArgs e)
    {
        content = EditorNotes.Text;
        File.WriteAllText(path, content);
        if(File.Exists(path))
        {
            DisplayAlert("File Overwritten", "Your File was overwritten sucessfuly", "Ok");
        }
        else
        {
            DisplayAlert("File Saved", "Your File was saved sucessfuly", "Ok");
        }
    }
    private void Button_Clicked_Delete(object sender, EventArgs e)
    {
        if(File.Exists(path)){
            File.Delete(path);
            TextEditor.Text = "";
            DisplayAlert("File Deleted", "Your File was deleted sucessfuly", "Ok");
        }
    }
    private void Button_Get_Clicked(object sender, EventArgs e)
    {
        if (File.Exists(path)){
            TextEditor.Text = File.ReadAllText(path);
        }
    }
}