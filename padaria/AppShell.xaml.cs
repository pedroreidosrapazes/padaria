using padaria.views;


namespace padaria
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            InicializeRouting();
        }

        public static void InicializeRouting()
        {
            Routing.RegisterRoute("cadastro", typeof(NewAcount));
        


        }
    }
}
  
