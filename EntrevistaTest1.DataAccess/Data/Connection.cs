namespace EntrevistaTest1.DataAccess.Data
{
    public static class Connection
    {
        private static readonly string connectionStringAC = "Data Source=.;Initial Catalog=AplicacionComercial;Integrated Security=True";
       
        private static readonly string connectionStringEntrevista1Test = "Data Source=.;Initial Catalog=Entrevista1Test;Integrated Security=True";

        public static string ConnectionStringAC 
        {
            get=>connectionStringAC; 
        }

        public static string ConnectionStringEntrevista1Test
        {
            get => connectionStringEntrevista1Test;
        }

    }
}
