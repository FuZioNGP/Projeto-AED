using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQL;

namespace ProjetoAED
{
    class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        ///             
        
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMenu());
            
            DataBase DB = new DataBase();
            DB.CriarBancoSQLite();
            DB.CriarTabelaSQlite();
        }
    }
}
