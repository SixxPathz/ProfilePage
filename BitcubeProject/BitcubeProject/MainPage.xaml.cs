namespace BitcubeProject

    

{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
       
    }

        private void EditProfile_Clicked(object sender, EventArgs e)
        {
           
            string websiteUrl = "https://sandile.netlify.app";

        
            Launcher.OpenAsync(new Uri(websiteUrl));
        }

     
    }

}
