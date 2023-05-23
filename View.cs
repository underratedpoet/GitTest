using GitTestApp.Run;


namespace GitTestApp
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
            WorkoutFacade.UploadInfo("Run\\workout_info.json");
        }

        private void View_Load(object sender, EventArgs e)
        {

        }
    }
}